using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePiece : MonoBehaviour
{
    public Color colorCorrecto; // Define el color correcto de esta pieza.
    public int finalColor;
    public int currentColor;
    public Text textoEstadoPieza; // Referencia al objeto de texto en Unity UI para mostrar el estado de la pieza.

    private bool estaPintada = false; // Bandera para rastrear si la pieza está pintada.
    public AudioSource audio_colorear;
    public AudioSource audio_borrar;

    // Función para comprobar si la pieza es correcta después de ser pintada.
    public bool EsCorrecta()
    {
        if (estaPintada)
        {
            // Compara el color actual con el color correcto.
            //return GetComponent<Renderer>().material.color == colorCorrecto;
            return currentColor == finalColor;
        }

        return false; // La pieza no está pintada.
    }

    // Función para pintar la pieza con un color dado.
    public void Pintar(Color color, int colorIndex)
    {
        GetComponent<Renderer>().material.color = color;
        estaPintada = true; // Marcar la pieza como pintada.
        currentColor = colorIndex;
        if (currentColor == 0)
        {
            audio_borrar.Play();
        }
        else
        {
            audio_colorear.Play();
        }

        // Mostrar el estado de la pieza en el objeto de texto.
        if (textoEstadoPieza != null)
        {
            textoEstadoPieza.text = "Estado de la pieza: Pintada";
        }
    }
}
