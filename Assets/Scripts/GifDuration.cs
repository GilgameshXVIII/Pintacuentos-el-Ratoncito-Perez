using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GifDuration : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Obt�n el componente Animator
        animator = GetComponent<Animator>();
    }
}