using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartahospital : MonoBehaviour
{
    public float interactionDistance = 3f;
    public GameObject interactionUI; // Canvas que se activará cuando el jugador esté en el rango

    private Transform player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Tecla E presionada");
            Interact();
        }
    }

    void Interact()
    {
        if (IsPlayerInRange())
        {
            Debug.Log("Jugador en rango");
            interactionUI.SetActive(true);
        }
        else
        {
            Debug.Log("Jugador fuera de rango");
            interactionUI.SetActive(false);
        }
    }

    bool IsPlayerInRange()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);
            return distance <= interactionDistance;
        }
        return false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = null;
            interactionUI.SetActive(false);
        }
    }
}

