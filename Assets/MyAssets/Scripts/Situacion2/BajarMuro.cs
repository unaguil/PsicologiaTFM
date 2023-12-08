using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BajarMuro : MonoBehaviour
{
    public float tiempoDeEspera;
    public int vel;
    public GameObject parteRestaurante;
    public GameObject canvas;

    public void Start()
    {
        //StartCoroutine(EmpezarAnimacion());
    }

    private IEnumerator EmpezarAnimacion()
    {
        yield return new WaitForEndOfFrame();

        if (transform.position.y > -5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (vel * Time.deltaTime), transform.position.z);
            StartCoroutine(EmpezarAnimacion());
        } else
        {
            parteRestaurante.GetComponent<TeleportationArea>().enabled = true;
            yield return new WaitForSeconds(5);
            canvas.SetActive(true);
        }
    }

    public IEnumerator Animacion()
    {
        Debug.Log("Empezar Animacion");
        yield return new WaitForSeconds(tiempoDeEspera);
        StartCoroutine(EmpezarAnimacion());
    }


}
