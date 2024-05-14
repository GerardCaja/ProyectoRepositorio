using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saberteclas : MonoBehaviour
{
    public GameObject keyImage; // La imagen de la tecla
    public float interactionDistance = 5f; // La distancia a la que el jugador puede interactuar con el objeto

    private Transform player; // El jugador

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Encuentra al jugador
        keyImage.SetActive(false); // Oculta la imagen de la tecla al inicio
    }

    void Update()
    {
        // Calcula la distancia entre el jugador y el objeto interactuable
        float distance = Vector3.Distance(player.position, transform.position);

        // Si el jugador está lo suficientemente cerca, muestra la imagen de la tecla
        if (distance <= interactionDistance)
        {
            keyImage.SetActive(true);
        }
        else // Si no, oculta la imagen de la tecla
        {
            keyImage.SetActive(false);
        }

        // Hace que la imagen de la tecla siempre mire hacia la cámara
        keyImage.transform.LookAt(player.position - transform.position);
    }
}
