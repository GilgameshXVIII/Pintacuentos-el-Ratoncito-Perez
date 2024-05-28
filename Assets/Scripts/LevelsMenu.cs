using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    private int dificultadSeleccionada = 1;
    private int nivelSeleccionado = 1;

    public void SeleccionarDificultad(int dificultad)
    {
        dificultadSeleccionada = dificultad;
    }

    public void SeleccionarNivel(int nivel)
    {
        nivelSeleccionado = nivel;
    }

    public void CargarNivel()
    {
        string nombreEscena = "Dificultad" + dificultadSeleccionada + "Nivel" + nivelSeleccionado;
        SceneManager.LoadScene(nombreEscena);
    }
}
