using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour
{
    private Vector3 posicion = new Vector3(-2.3f, 1f, 2.6f);
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "collider bolas")
        {
            Debug.Log("Llega");
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            gameObject.transform.position = posicion;
        }
    }
}
