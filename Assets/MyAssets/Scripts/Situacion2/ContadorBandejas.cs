using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBandejas : MonoBehaviour
{
    public GameObject cambiarEscena;
    Boolean bandeja1dentro = false;
    Boolean bandeja2dentro = false;
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

            if (bandeja1dentro && bandeja2dentro)
            {
                cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();
            }
        }
        else if (other.gameObject.name == "Bandeja2")
        {
            bandeja2dentro = true;

            if (bandeja1dentro && bandeja2dentro)
            {
                cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();
            }
        }
        Debug.Log(bandeja1dentro + ":" + bandeja2dentro);
    }
}
