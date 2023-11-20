using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public XRController controller = null;
    InputDevice device;
    // Start is called before the first frame update
    public static IEnumerator EsperarYCambiarDeEscena(string nombreEscena)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(nombreEscena);
    }
    
    public void saltarEscena()
    {
        Debug.Log("Saltar escena");
        SceneManager.LoadScene("Situacion1");
    }
}
