using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Composites;

public class GuiaAvion : MonoBehaviour
{

    public GameObject[] objetivos;
    public float speed = 5f;
    public GameObject plataformaFinal;

    private int objetivoActual = 0;

    private void Update()
    {
        if (objetivoActual < objetivos.Length)
        {
            // ir al actual
            Vector3 direccionA = objetivos[objetivoActual].transform.position - transform.position;
       
            if (direccionA.magnitude < 0.1f)
            {
                objetivoActual++;
                if (objetivoActual >= objetivos.Length)
                {
                    objetivoActual = 0;
                    //Debug.Log("Ha pasado por todos los objetivos");
                }
            }
            // Mover el avión hacia adelante a una velocidad constante
            transform.Translate(direccionA.normalized * speed * Time.deltaTime, Space.World);

            // Orientar el avión hacia el objetivo actual
            Quaternion targetRotation = Quaternion.LookRotation(direccionA);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Jelly Fish Net")
        {
            this.gameObject.SetActive(false);
            plataformaFinal.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Jelly Fish Net")
        {
            this.gameObject.SetActive(false);
            plataformaFinal.SetActive(true);
        }
    }

}
