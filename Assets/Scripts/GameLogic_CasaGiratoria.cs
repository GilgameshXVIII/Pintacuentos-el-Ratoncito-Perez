using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic_CasaGiratoria : MonoBehaviour
{
    private PuzzlePiece[] listaDePiezas;
    public int totalPiezas = 13; // Define la cantidad total de piezas en el rompecabezas.
    private int piezasCorrectas = 0; // Inicialmente, no hay piezas correctas.
    public Text textoPorcentaje;
    public ColorSelectionUI colorSelectionUI; // Asigna el objeto de UI ColorSelectionUI en el Inspector.
    public Color selectedcolor; // El color seleccionado actualmente.
    public GameObject completionCanvas; // Asigna el objeto Canvas en el Inspector.
    public GameObject gif; // Asigna el objeto Gif en el Inspector.
    public GameObject check; // Asigna el objeto Check en el Inspector.
    //public float tiempoBloqueoInteraccion = 3f; // Tiempo en segundos para bloquear la interacción después de completar el puzzle.
    //private bool bloquearInteraccion = false; // Bandera para bloquear la interacción.

    // Función para cambiar el color seleccionado.
    public void ChangeSelectedColor(Color newColor)
    {
        selectedcolor = newColor;
        if (colorSelectionUI != null)
        {
            colorSelectionUI.UpdateSelectedColor(selectedcolor);
        }
    }

    private void Start()
    {
        listaDePiezas = new PuzzlePiece[transform.childCount];
        listaDePiezas = GetComponentsInChildren<PuzzlePiece>();
    }
    public void ActualizarPiezas()
    {
        /*if (bloquearInteraccion)
        {
            return; // Evita actualizar las piezas si la interacción está bloqueada.
        }*/

        piezasCorrectas = 0;

        for (int i = 0; i < totalPiezas; i++)
        {
            ComprobarPiezaCorrecta(listaDePiezas[i].EsCorrecta());
        }

        Debug.Log("piezasCorrectas: "+ piezasCorrectas+" total de piezas: "+totalPiezas);

        if (totalPiezas == piezasCorrectas)
        {
            Debug.Log("¡Has completado el puzzle!");
            // Activa el Canvas de completado.
            completionCanvas.SetActive(true);
            // Activa el Gif de completado.
            gif.SetActive(true);
            // Activa el Check de completado.
            check.SetActive(true);
            // Bloquea la interacción durante el tiempo especificado.
            //bloquearInteraccion = true;
            // Desactiva el Canvas y desbloquea la interacción después de 3 segundos.
            //Invoke("DesactivarCanvasCompletado", tiempoBloqueoInteraccion);
        }
    }
    // Desactiva el Canvas de completado y desbloquea la interacción.
    private void DesactivarCanvasCompletado()
    {
        gif.SetActive(false);
        completionCanvas.SetActive(false);
        //bloquearInteraccion = false;
    }
    // Función para comprobar si una pieza es correcta y actualizar el contador.
    public void ComprobarPiezaCorrecta(bool esCorrecta)
    {
        if (esCorrecta)
        {
            piezasCorrectas++;
        }
    }
}
