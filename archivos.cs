using System;
using System.IO;
public class ARCHIVO
{
    public static string[] Obtener(string rutaDArchivo)
    {
        string[] list = Directory.GetFiles(rutaDArchivo); 
        return list;
    }
    public static  void Mostrar(string[] lista)
    {
        foreach (string f in lista)
        {
            Console.WriteLine(f);
        }
    }

}