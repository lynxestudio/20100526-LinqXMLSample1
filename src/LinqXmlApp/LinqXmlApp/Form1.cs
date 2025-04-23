using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;

namespace LinqXmlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            XElement articulos = new XElement("Articulos",
    new XElement("Articulo", new XElement("IdArticulo", "1"),
    new XElement("Codigo", "C01-01-C12140"),
    new XElement("Nombre", "CATGUT CROMICO 4-0 30CM C1214/2-30")),
    new XElement("Articulo", new XElement("IdArticulo", "2"),
    new XElement("Codigo", "C01-01-C26109"),
    new XElement("Nombre", "ACERO 2 45CM C26109x2")),
    new XElement("Articulo", new XElement("IdArticulo", "3"),
    new XElement("Codigo", "C01-01-C40590"),
    new XElement("Nombre", "POLIESTER 2 75CM C4059")));
            string s  = articulos.ToString();
            XmlFile.Text = s;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(XmlFile.Text))
            {
                MessageBox.Show("Generate Xml first.");
            }
            else
            {
                if(string.IsNullOrEmpty(txtQuery.Text))
                {
                    MessageBox.Show("Enter a query");
                }
                else
                {
                    store.Items.Clear();
                    using (MemoryStream mem = new MemoryStream())
                    {
                        byte[] bs = ASCIIEncoding.ASCII.GetBytes(XmlFile.Text);
                        mem.Write(bs, 0, bs.Length);
                        mem.Position = 0;
                        using (StreamReader reader = new StreamReader(mem))
                        {
                            XElement xml = XElement.Load(reader);
                            var q = from s in xml.Elements("Articulo")
                                    where s.Value.Contains(txtQuery.Text)
                                    select s;

                            foreach (var r in q)
                            {

                                XmlReader xmlReader = r.CreateReader();
                                int i = 0;
                                string s = null;
                                while (xmlReader.Read())
                                {

                                    if (xmlReader.HasValue)
                                    {
                                        s += xmlReader.Value + "|";
                                        i++;
                                    }

                                }
                                if (i == 3)
                                    store.Items.Add(s);
                            }
                        }
                    }//end mem
                }
                
            }
            
        }
    }
}
