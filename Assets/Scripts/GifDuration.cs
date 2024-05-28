using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GifDuration : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Obtén el componente Animator
        animator = GetComponent<Animator>();
    }
}