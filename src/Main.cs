using System;
using System.Linq;
using System.Xml.Linq;


namespace PrimerLinqXML
{
	class MainClass
	{
		public static void Main (string[] args)
		{
	XElement articulos = new XElement("Articulos",
	new XElement("Articulo",new XElement("IdArticulo","1"),
	new XElement("Codigo","C01-01-C12140"),
	new XElement("Nombre","CATGUT CROMICO 4-0 30CM C1214/2-30")),
	new XElement("Articulo",new XElement("IdArticulo","2"),
	new XElement("Codigo","C01-01-C26109"),
	new XElement("Nombre","ACERO 2 45CM C26109x2")),
	new XElement("Articulo",new XElement("IdArticulo","3"),
	new XElement("Codigo","C01-01-C40590"),
	new XElement("Nombre","POLIESTER 2 75CM C4059")));
	Console.WriteLine(articulos.ToString());
	Console.Read();
		}
	}
}
