using System;
using System.IO;
//obteniendo archivo del directorio
Console.WriteLine("Muestra de los archivos del directorio Seleccionado:");
string[] files = Directory.GetFiles(@"C:\Users\USUARIO\Desktop\DirectorioTP8"); 
//mostramos archivos en la consola
foreach (string f in files)
{
    Console.WriteLine(f);
}
// crea el archivo en la ruta especificada 
string ruta = @"C:\Users\USUARIO\Desktop\DirectorioTP8\MyTest.cvs";
if (!File.Exists(ruta))//validacion de su existencia
{
    File.Create(ruta);
}
//abrir el archivo para su escritura
FileStream Fstream = new FileStream(ruta, FileMode.Open);
int numRegistro=0;
// string exten="";
using (StreamWriter StreamW = new StreamWriter(Fstream))
{
    foreach (string dir in files)
    { 
        numRegistro++;
        string[] linea = dir.Split('.');//separamos la ruta en arreglo respecto al punto
        int a=linea.Length;//contamos la cantidad de elementos en el arreglo
        StreamW.WriteLine(numRegistro.ToString()+','+dir+','+linea[a-1]);//asignamo la extencion del arreglo en base al tamaño menos uno
    }
}
//cerrar el archivo
Fstream.Close();
// Console.WriteLine("File Name = " + FileOp.FullName);//posible uso para sacar la extencion

// apertura del archivo
// using (StreamReader sr = File.OpenText(ruta))
// {
//     string s;
//     while ((s = sr.ReadLine()) != null)
//     {
//        Console.WriteLine(s);
//     }
//     sr.Close();
// }
Console.WriteLine();
Console.WriteLine("FIN.");