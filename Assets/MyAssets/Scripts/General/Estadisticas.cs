using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;

public class Estadisticas
{

    private static List<string> estadisticas = new List<string>();
    
    public static void NuevaEstadistica(string s)
    {
        estadisticas.Add(s);
    }

    public static void GuardarEstadisticas()
    {
       // string path = "data/estadisticas.csv";
        string path = Application.persistentDataPath+"/estadisticas.csv";
        Encoding encoding = Encoding.Unicode;
        StreamWriter sr = new StreamWriter(path, true, encoding);
        foreach (string s in estadisticas)
        {
            sr.Write(s);
        }
        sr.Write("\n");
        sr.Close();
    }

    public static void GuardarFechaHora()
    {

        Debug.Log("Guardar fecha hora");
        String fecha = DateTime.Now.ToString("dd/MM/yyyy");
        String hora = DateTime.Now.ToString("HH:mm");
        estadisticas.Add(fecha+";");
        estadisticas.Add(hora+";");
    }




}
