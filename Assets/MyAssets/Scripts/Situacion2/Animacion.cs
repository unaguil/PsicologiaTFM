using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
{
    public Animator animator;

    public void EmpezarAnimacion()
    {
        animator.SetBool("mover", true);
    }

    public void AcabarAnimacion()
    {
        animator.SetBool("mover", false);
    }
}
