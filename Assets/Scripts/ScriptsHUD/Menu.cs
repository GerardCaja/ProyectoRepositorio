using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nombreDeEscena; // Nombre de la escena a la que quieres cambiar

    public string NivelCasa = "NivelCasa";

    public void CambiarEscena()
    {
        SceneManager.LoadScene(NivelCasa);
    }
}

