using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBandejas : MonoBehaviour
{
    public GameObject cambiarEscena;
    bool bandeja1dentro = false;
    bool bandeja2dentro = false;

    bool bandeja1agarrada = false;
    bool bandeja2agarrada = false;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Bandeja1")
    //    {
    //        bandeja1dentro = true;

    //        if (bandeja1dentro && bandeja2dentro)
    //        {
    //            cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();
    //        }
    //    }else if (other.gameObject.name == "Bandeja2")
    //    {
    //        bandeja2dentro = true;

    //        if (bandeja1dentro && bandeja2dentro)
    //        {
    //            cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();
    //        }
    //    }
    //    Debug.Log(bandeja1dentro +":"+ bandeja2dentro);
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.name == "Bandjea1")
    //    {
    //        bandeja1dentro = false;
    //    } else if (other.gameObject.name == "Bandeja2")
    //    {
    //        bandeja2dentro = false;
    //    }
    //    Debug.Log(bandeja1dentro + ":" + bandeja2dentro);
    //}

    public void Update()
    {
        bandeja1dentro = false;
        bandeja2dentro = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Bandeja1")
        {
            bandeja1dentro = true;

            if (bandeja1dentro && bandeja2dentro && !bandeja1agarrada && !bandeja2agarrada)
            {
                StartCoroutine(CorrutinaCambiarEscena());
            }
        }
        else if (other.gameObject.name == "Bandeja2")
        {
            bandeja2dentro = true;

            if (bandeja1dentro && bandeja2dentro && !bandeja1agarrada && !bandeja2agarrada)
            {
                StartCoroutine(CorrutinaCambiarEscena());
            }
        }
        Debug.Log(bandeja1dentro + ":" + bandeja2dentro + ":" + bandeja1agarrada + ":" + bandeja2agarrada);
    }

    public void AgarrarBandeja(GameObject bandeja)
    {
        Debug.Log("Bandeja agarrada");
        if (bandeja.name == "Bandeja1")
        {
            bandeja1agarrada = true;
        } else if (bandeja.name == "Bandeja2")
        {
            bandeja2agarrada = true;
        }
    }

    public void SoltarBandeja(GameObject bandeja)
    {
        Debug.Log("Bandeja soltada");
        if (bandeja.name == "Bandeja1")
        {
            bandeja1agarrada = false;
        }
        else if (bandeja.name == "Bandeja2")
        {
            bandeja2agarrada = false;
        }
    }

    private IEnumerator CorrutinaCambiarEscena()
    {
        yield return new WaitForSeconds(1);
        cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();

    }
}
