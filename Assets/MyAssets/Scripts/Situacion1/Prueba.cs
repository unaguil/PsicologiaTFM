using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Given vector
        Vector3 originalVector = new Vector3(1.0f, 2.0f, 3.0f);

        // Find a perpendicular vector using cross product
        Vector3 perpendicularVector1 = Vector3.Cross(originalVector, Vector3.up).normalized;

        // Find another perpendicular vector using cross product
        Vector3 perpendicularVector2 = Vector3.Cross(originalVector, perpendicularVector1).normalized;
        Vector3 perpendicularVector3 = Vector3.Cross(originalVector, perpendicularVector2).normalized;

        // Output the results
        Debug.Log("Original Vector: " + originalVector);
        Debug.Log("Perpendicular Vector 1: " + perpendicularVector1);
        Debug.Log("Perpendicular Vector 2: " + perpendicularVector2);
        Debug.Log("Perpendicular Vector 2: " + perpendicularVector3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
