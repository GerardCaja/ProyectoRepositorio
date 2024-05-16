using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCompletao : MonoBehaviour
{
    // Supongamos que esta función se llama cuando se completa el puzzle
    public void OnPuzzleComplete()
    {
        // Cambia a la siguiente escena
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
