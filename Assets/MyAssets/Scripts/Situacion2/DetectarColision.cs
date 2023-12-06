using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour
{
    private Vector3 posicion = new Vector3(1f, 0f, -3f);

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "ParteRestaurante")
        {
            Debug.Log("Llega");
            gameObject.transform.position = posicion;
        }
    }
}
