using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushScript : MonoBehaviour
{
    private bool isPainting = false;
    private Color currentColor;
    private float brushSize = 0.1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isPainting)
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Renderer rend = hit.transform.GetComponent<Renderer>();
                if (rend != null)
                {
                    rend.material.color = currentColor;
                }
            }
        }
    }

    public void StartPainting(Color color)
    {
        isPainting = true;
        currentColor = color;
    }

    public void StopPainting()
    {
        isPainting = false;
    }

    public void SetBrushSize(float size)
    {
        brushSize = size;
    }
}
