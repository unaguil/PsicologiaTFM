using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class CargarFichero : MonoBehaviour
{
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            string path = Application.persistentDataPath + "/estadisticas.csv";
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            while (line != null)
            {
                text.text += line;
            }
        } catch (Exception e)
        {
            text.text = e.Message;
        }
        
    }
}
