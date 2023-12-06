using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public XRController controller = null;
    //InputDevice device;
    public string escenaSiguiente;
    public GameObject canvas;
    public TMP_Text tmp;
    // Start is called before the first frame update
    public IEnumerator EsperarYCambiarDeEscena(string nombreEscena)
    {
        Debug.Log("Cambiar escena");
        canvas.SetActive(true);
        //Debug.Log(canvas.isActiveAndEnabled);
        yield return new WaitForSeconds(1);
        tmp.text = "CAMBIO DE ESCENA EN 2";
        yield return new WaitForSeconds(1);
        tmp.text = "CAMBIO DE ESCENA EN 1";
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nombreEscena);
    }
    
    public void saltarEscena()
    {
        //Debug.Log("Saltar escena");
        //SceneManager.LoadScene(escenaSiguiente);
        StartCoroutine(EsperarYCambiarDeEscena(escenaSiguiente));
    }
}
