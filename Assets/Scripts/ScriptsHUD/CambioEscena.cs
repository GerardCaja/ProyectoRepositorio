using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Nombre de la escena del puzzle
    public string Puzzle;

    void Update()
    {
        // Verificar si se presiona la tecla "Q"
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Cargar la escena del puzzle
            SceneManager.LoadScene(Puzzle);
        }
    }
}

