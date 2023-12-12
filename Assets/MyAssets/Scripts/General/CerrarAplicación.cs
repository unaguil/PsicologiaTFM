using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarAplicación : MonoBehaviour
{
    public void CloseApp()
    {
        Estadisticas.GuardarEstadisticas();
        Application.Quit();
    }
}
