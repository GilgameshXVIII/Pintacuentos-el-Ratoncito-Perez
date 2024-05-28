using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedMessage : MonoBehaviour
{
    // Invocado cuando el jugador hace clic o toca la pantalla.
    public void OcultarMensaje()
    {
        // Desactiva el Canvas para ocultar el mensaje.
        gameObject.SetActive(false);
    }
}
