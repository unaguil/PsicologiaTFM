using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurarInterfaz : MonoBehaviour
{
    public GameObject interfaz;

    void Start()
    {
        interfaz.GetComponent<Interfaz>().ConfiguracionInicial();
    }
}
