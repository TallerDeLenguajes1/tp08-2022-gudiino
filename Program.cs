using System;
using System.IO;
//obteniendo archivo del directorio
Console.WriteLine("Muestra de los archivos del directorio Seleccionado:");
string rutaDArchivo = @"C:\Users\USUARIO\Desktop\DirectorioTP8\";
string[] files = ARCHIVO.Obtener(rutaDArchivo); 
//mostramos archivos en la consola
ARCHIVO.Mostrar(files);
//guardar la informacion listada
 string nomDArchivo = "listaArchivos.csv";
archivoCSV.GuardarCSV((rutaDArchivo+nomDArchivo),files);
// apertura lestura del archivo
List<string[]> listaArchivos = archivoCSV.LeerCSV((rutaDArchivo+nomDArchivo), ';');
Console.WriteLine("Muestra de los datos en la lista de archivos CSV");
foreach (var item in listaArchivos)
{
    Console.Write("Registro: "+item[0].ToString());
    Console.Write(" -- Ruta: "+item[1]);
    Console.WriteLine(" -- Extension: "+item[2]);
}
Console.WriteLine();
Console.WriteLine("FIN.");