using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaTrucada : MonoBehaviour
{
    public static float fuerzaMin = -150;
    public static float fuerzaMax = 150;
    public static Vector3 fuerza;
    //public float fuerzaMin;
    //public float fuerzaMax;
    //public Vector3 fuerza;

    public void Prueba()
    {
        Debug.Log("Hola");
    }

    public void Desviar()
    {
        Vector3 vectorAleatorio = new Vector3(Random.Range(fuerzaMin, fuerzaMax), 0, Random.Range(fuerzaMin, fuerzaMax));
        gameObject.GetComponent<Rigidbody>().AddForce(vectorAleatorio);
        Debug.Log(gameObject.GetComponent<Rigidbody>().GetAccumulatedForce());
    }
}
