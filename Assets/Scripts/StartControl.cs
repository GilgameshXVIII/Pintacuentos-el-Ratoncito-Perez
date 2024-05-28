using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartControl : MonoBehaviour
{
    public float homeScreenDuration = 5f; // Tiempo en segundos para mostrar la pantalla de inicio.

    void Start()
    {
        // Invoca la función para cargar el menú principal después de la duración de la pantalla de inicio.
        Invoke("LoadMainMenu", homeScreenDuration);
    }

    void LoadMainMenu()
    {
        // Carga la escena del menú principal.
        SceneManager.LoadScene("Main Menu");
    }
}
