using System;
using System.IO;
Console.WriteLine("Hello, World!");
string[] files = Directory.GetFiles(@"C:\Users\USUARIO\Desktop\DirectorioTP8"); // Obtener archivos 
foreach (string f in files)
{
    Console.WriteLine(f); // Mostramos los archivos en la consola
}
string[] folders = Directory.GetDirectories(@"C:\Users\USUARIO\Desktop\DirectorioTP8");
foreach (string f in folders)
{
    Console.WriteLine("> "+f); // Mostramos las carpetas en la consola
}
string path = @"C:\Users\USUARIO\Desktop\DirectorioTP8\MyTest.cvs";
if (!File.Exists(path))
{
    int numRegistro=5;
    string ruta="ruta/del/archivo";
    string exten="extn";
    // Create a file to write to.
    using (StreamWriter sw = File.CreateText(path))
    {
        sw.WriteLine(numRegistro.ToString()+','+ruta+','+exten);
    }
}

// apertura del archivo
using (StreamReader sr = File.OpenText(path))
{
    string s;
    while ((s = sr.ReadLine()) != null)
    {
       Console.WriteLine(s);
    }
    sr.Close();
}
Console.WriteLine("FIN3.");