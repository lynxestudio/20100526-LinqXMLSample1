# Trabajando LINQ para XML con Monodevelop Parte I de II

XML se ha convertido en un excelente estándar abierto para el intercambio de información entre aplicaciones de software debido a la manera de representar información estructurada, independiente de la plataforma, lenguaje de programación o sistema operativo, es utilizado extensamente en archivos y protocolos de Internet por ser un formato fácil de leer y suficientemente flexible para adaptarse a muchos propósitos. Debido a estas características XML y sus tecnologías están completamente integradas y soportadas por la plataforma .NET mediante un conjunto de clases que proporcionan lectura y escritura de documentos, validación, navegación, serialización, transformación y búsquedas. Aunque estas clases son suficientes para trabajar con XML su utilización no es sencilla y puede producir código difícil de mantener, por lo que .NET incorpora LINQ para XML (LINQ to XML) como una mejor manera de trabajar con XML.


Creando el archivo XML
Para mostrar de una manera práctica la utilización de LINQ para XML, ejecutamos MonoDevelop y creamos una nueva solución en el menú “Archivo”, del lado derecho de la ventana de nueva solución seleccionamos el icono que dice “Solución en blanco” y en el cuadro de texto nombre escogemos “LinqXML”, esta será la solución que contenga los dos proyectos de este tutorial.

Agregamos a nuestra solución un proyecto de consola, le llamamos CrearXML , como se muestra en la siguiente imagen.

Para que el soporte de LINQ a XML es importante hacer referencia a los siguientes ensamblados:

System.Linq Es el ensamblado principal y básico que contiene todas las clases e interfaces para trabajar con LINQ.

System.Xml.LinqContiene las clases y extensiones para manipular XML con LINQ.

Esto se logra haciendo click derecho sobre el archivo de proyecto y en el menú desplegable escogemos la opción “Editar referencias” (Edit References) como se muestra en la imagen siguiente.

Ahora completamos el código generado por monodevelop, para que el programa completo quede como en el siguiente listado.

La diferencia de la sintaxis para crear documentos XML con respecto a la sintaxis empleada con las clases del ensamblado System.Xml, es que esta sintaxis se enfoca más en los elementos (representados por la clase XElement) que en el documento (representado en la clase Xdocument ).
En este listado creamos el documento XML de una manera declarativa anidando varias objetos XElement dentro de un objeto Xdocument , al final llamamos al método Save para guardar el XML en el disco.
Construimos la aplicación pulsando la tecla F8 y al ejecutarse veremos el resultado en la ventana de salida de MonoDevelop como se muestra en la imagen siguiente.
