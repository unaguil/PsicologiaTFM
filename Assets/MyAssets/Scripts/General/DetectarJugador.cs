using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarJugador : MonoBehaviour
{
    public GameObject jugador;
    public GameObject cambiarEscena;
    Boolean yaHaEntrado = false;

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Collider>().bounds.Contains(jugador.transform.position) && !yaHaEntrado)
        {
            Debug.Log("Ha entrado");
            StartCoroutine(activarInterfazRetardado());
            yaHaEntrado=true;
        }
    }

    public IEnumerator activarInterfazRetardado()
    {
        yield return new WaitForSeconds(2);
        cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();
    }
}
