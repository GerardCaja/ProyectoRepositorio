using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartahospital : MonoBehaviour
{
    public GameObject objeto; // El objeto con el que el jugador interactuará
    public GameObject canvas; // El canvas que quieres activar y desactivar
    public float distanciaInteraccion = 5f; // La distancia a la que el jugador puede interactuar con el objeto

    void Update()
    {
        // Calcula la distancia entre el jugador y el objeto
        float distancia = Vector3.Distance(objeto.transform.position, transform.position);

        // Si el jugador está lo suficientemente cerca y presiona la tecla "E"
        if (distancia <= distanciaInteraccion && Input.GetKeyDown(KeyCode.E))
        {
            // Cambia el estado de activación del canvas
            canvas.SetActive(!canvas.activeSelf);
        }
    }
}
