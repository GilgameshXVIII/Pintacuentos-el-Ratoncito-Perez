using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBucket : MonoBehaviour
{
    public GameLogic_CasaGiratoria piecesManager;
    public Color[] colorList;
    public Color curColor;
    public int colorCount;

    void Start()
    {

    }

    void Update()
    {
        curColor = colorList[colorCount];

        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);

        if (Input.GetButtonDown("Fire1"))
        {
            if (hit.collider != null)
            {

                PuzzlePiece pp = hit.collider.gameObject.GetComponent<PuzzlePiece>();
                Debug.Log(hit.collider.name);

                pp.Pintar(curColor, colorCount);
                piecesManager.ActualizarPiezas();
            }
            
        }
    }

    public void paint(int colorCode)
    {
        colorCount = colorCode;
    }
}