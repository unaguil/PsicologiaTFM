using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiaBolas2 : MonoBehaviour
{
    public GameObject[] objetivos;
    public float fuerza;

    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "SledgeHammer")
        {
            GameObject objetivo = buscarObjetivoMasCercano();
            Debug.Log(objetivo.name);
            StartCoroutine(Prueba());
        }
    }

    public GameObject buscarObjetivoMasCercano()
    {
        GameObject objetivo = null;
        float distanciaMinima = Mathf.Infinity;
        foreach (GameObject obj in objetivos)
        {
            Vector3 vector = new Vector3(obj.transform.position.x - transform.position.x, obj.transform.position.y - transform.position.y, obj.transform.position.z - transform.position.z);
            if (vector.magnitude < distanciaMinima)
            {
                distanciaMinima = vector.magnitude;
                objetivo = obj;
            }
        }
        return objetivo;
    }

    private IEnumerator Prueba()
    {
        Debug.Log("Hola1");
        yield return new WaitForSeconds(1);
        Debug.Log("Hola2");
        StartCoroutine(Prueba());
    }
}
