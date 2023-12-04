using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
    public static string registro;

    public GameObject preguntaActual;
    public GameObject siguientePregunta;
    public TMP_Text text;
    public GameObject cambiarEscena;

    private float valorSlider;

    public void ConfiguracionInicial()
    {
        string nombre = SceneManager.GetActiveScene().name;
        registro = nombre+";";
    }

    public void RespuestaBoton(string s)
    {
        registro = registro + s + ";";
        Debug.Log(registro);
        preguntaActual.SetActive(false);
        if (siguientePregunta != null)
        {
            siguientePregunta.SetActive(true);
        } else
        {
            try
            {
                GuardarRegistro();
            } catch (Exception e)
            {
                text.text = e.Message;
            }
            cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();

        }
    }

    public void RespuestaSlider(float f)
    {
        valorSlider = f;
       // Debug.Log(valorSlider);
    }

    public void ConfirmarSlider()
    {
        registro = registro + valorSlider.ToString("0.00") + ";";
        Debug.Log(registro);
        preguntaActual.SetActive(false);
       // Debug.Log(siguientePregunta);
        if (siguientePregunta != null)
        {
            siguientePregunta.SetActive(true);
        }
        else
        {
            GuardarRegistro();
            cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();
        }
    }

    public void GuardarRegistro ()
    {
        Debug.Log(registro);
        Estadisticas.NuevaEstadistica(registro);
        Estadisticas.GuardarEstadisticas();
    }
}
