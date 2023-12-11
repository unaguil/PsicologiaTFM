using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision2 : MonoBehaviour
{
    private Vector3 posicion = new Vector3(1.119f, 0.263f, -3.64f);
    public GameObject red;

    public void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position = red.transform.position;
        collision.rigidbody.velocity = Vector3.zero;
        Debug.Log("Se cae");
    }
}
