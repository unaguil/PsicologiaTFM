using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class contadorBombillas : MonoBehaviour
{
    public GameObject luz;
    public GameObject bombilla;
    public GameObject click;
    private float nuevaRot = 90.02f;
    private static int contador = 0;

    public void EncerderLuz()
    {
        Vector3 rotActual = click.transform.eulerAngles;

        rotActual.x = nuevaRot;
        click.transform.eulerAngles = rotActual;

        contador++;
        Debug.Log("Detecta: " + contador);

        if (contador == 3)
        {
            bombilla.SetActive(true);
            luz.SetActive(false);
        }      
    }

 
}
