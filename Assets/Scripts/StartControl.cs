using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartControl : MonoBehaviour
{
    public float homeScreenDuration = 5f; // Tiempo en segundos para mostrar la pantalla de inicio.

    void Start()
    {
        // Invoca la funci�n para cargar el men� principal despu�s de la duraci�n de la pantalla de inicio.
        Invoke("LoadMainMenu", homeScreenDuration);
    }

    void LoadMainMenu()
    {
        // Carga la escena del men� principal.
        SceneManager.LoadScene("Main Menu");
    }
}
