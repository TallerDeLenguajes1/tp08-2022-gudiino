using System;
using System.IO;
public class archivoCSV
{
    public static void GuardarCSV(string ruta, string[] lista)
    {
        if (!File.Exists(ruta))//verificacion de la existencia del archivo
        {
            File.Create(ruta);
        }
        FileStream Fstream = new FileStream(ruta, FileMode.Open);
        int numRegistro=0;
        using (StreamWriter StreamW = new StreamWriter(Fstream))
        {
            foreach (string dir in lista)
            { 
                numRegistro++;
                string[] linea = dir.Split('.');//separamos la ruta en arreglo respecto al punto
                int a=linea.Length;//contamos la cantidad de elementos en el arreglo
                StreamW.WriteLine(numRegistro.ToString()+';'+dir+';'+linea[a-1]);//asignamo la extencion del arreglo en base al tamaño menos uno
            }
        }//using libera los recursos
        //cerrar el archivo
        Fstream.Close();//se cierra con using pero lo usamos por cuestiones de practica
        // Console.WriteLine("File Name = " + FileOp.FullName);//posible uso para sacar la extencion
    }
    public static List<string[]> LeerCSV(string ruta, char caracter)
    {
        FileStream MiCSV = new FileStream(ruta, FileMode.Open);
        StreamReader StrReader = new StreamReader(MiCSV);
        string Linea = "";
        List<string[]> listaDArchivo = new List<string[]>();

        while ((Linea = StrReader.ReadLine()) != null)
        {
            string[] Fila = Linea.Split(caracter);
            listaDArchivo.Add(Fila);
        }

        return listaDArchivo;
    }
}