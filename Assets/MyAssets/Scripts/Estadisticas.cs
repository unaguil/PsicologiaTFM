using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estadisticas
{

    private static List<string> estadisticas = new List<string>();
    
    public static void NuevaEstadistica(string s)
    {
        estadisticas.Add(s);
    }


}
