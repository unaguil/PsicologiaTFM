using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interfaz : MonoBehaviour
{
    // Start is called before the first frame update
    public void Respuesta1(BaseEventData eventData)
    {
        Debug.Log(eventData.selectedObject);
    }

    public void Respuesta1(string s)
    {
       
    }
}
