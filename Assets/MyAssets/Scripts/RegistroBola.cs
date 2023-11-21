using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegistroBola : MonoBehaviour
{
    public static int contador = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(this.gameObject.layer +" "+ collision.gameObject.layer);

        if (collision.gameObject.layer == this.gameObject.layer)
        {
            contador++;
            Debug.Log("Color: "+ LayerMask.LayerToName(this.gameObject.layer) + " Canasta anotada. Contador: " + contador);
            Destroy(collision.gameObject);
            //Estadisticas.prueba = "Funciona";

            if (contador == 9)
            {
                Debug.Log("Se han metido todas las pelotas");
                StartCoroutine(CambiarEscena.EsperarYCambiarDeEscena("Situacion1"));
            }
        }
        

    }

}
