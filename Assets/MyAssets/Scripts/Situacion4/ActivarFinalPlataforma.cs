using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarFinalPlataforma : MonoBehaviour
{
    public GameObject player;
    public GameObject cambiaEscena;

    public void Update()
    {
        //Debug.Log(player.transform.position.z);
        if (player.transform.position.z > 1.6) 
        {
            Debug.Log("CambiarEscena");
            cambiaEscena.GetComponent<CambiarEscena>().saltarEscena();
        }
    }
}
