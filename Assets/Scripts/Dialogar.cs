using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogar : MonoBehaviour
{
    public GameObject canvas; // Asigna el Canvas en el Inspector

    void Update()
    {
        // Si se presiona la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Activa el Canvas
            canvas.SetActive(true);
        }
    }
}
