using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoriaHospital : MonoBehaviour
{
    private int objetosRecogidos = 0;
    private int totalObjetos = 3;

    public void ObjetoRecogido()
    {
        objetosRecogidos++;

        if (objetosRecogidos >= totalObjetos)
        {
            // Cambia a la siguiente escena
            SceneManager.LoadScene("Victoria");
        }
    }
}