using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
    public static string registro;

    public GameObject preguntaActual;
    public GameObject siguientePregunta;

    private float valorSlider;

    public void ConfiguracionInicial()
    {
        string nombre = SceneManager.GetActiveScene().name;
        registro = nombre+";";
    }

    public void Respuesta1(BaseEventData eventData)
    {
        Debug.Log(eventData.selectedObject);
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
            GuardarRegistro();
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
        }
    }

    public void GuardarRegistro ()
    {
        Debug.Log(registro);
        Estadisticas.NuevaEstadistica(registro);
        Estadisticas.GuardarEstadisticas();
    }
}
