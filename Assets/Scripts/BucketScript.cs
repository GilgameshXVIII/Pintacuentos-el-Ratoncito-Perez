using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketScript : MonoBehaviour
{
    public Color fillColor;

    public void FillArea()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            Renderer rend = hit.transform.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = fillColor;
            }
        }
    }
}
