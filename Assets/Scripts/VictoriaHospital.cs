using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaHospital : MonoBehaviour
{
    public GameObject completionScreen;
    private int objetosRecogidos = 0;
    private int totalObjetos = 3;

    public void ObjetoRecogido()
    {
        objetosRecogidos++;

        if (objetosRecogidos >= totalObjetos)
        {
            // Carga el canvas de victoria
            completionScreen.SetActive(true);
        }
    }
}