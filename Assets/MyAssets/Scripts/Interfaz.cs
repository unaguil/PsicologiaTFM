using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
    private static string registro;

    public GameObject preguntaActual;
    public GameObject siguientePregunta;

    private float valorSlider;

    private void Awake()
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
        Debug.Log(valorSlider);
    }

    public void ConfirmarSlider()
    {
        registro = registro + valorSlider.ToString("0.00") + ";";
        preguntaActual.SetActive(false);
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
        //Estadisticas.NuevaEstadistica(registro);
    }
}
