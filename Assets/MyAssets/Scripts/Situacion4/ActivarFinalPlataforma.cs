using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarFinalPlataforma : MonoBehaviour
{
    public GameObject player;
    public GameObject cambiaEscena;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Main Camera")
        {
            Debug.Log("Colisiona");
        }
    }
}
