using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoEscuela : MonoBehaviour
{
    public GameObject interactableObject; // El objeto con el que interactuamos
    public VideoPlayer videoPlayer; // El VideoPlayer
    public Canvas canvas; // El Canvas que contiene el video
    public KeyCode interactKey = KeyCode.E; // La tecla para interactuar

    private bool isNearObject = false;

    void Update()
    {
        if (isNearObject && Input.GetKeyDown(interactKey))
        {
            Debug.Log("Key pressed and near object. Attempting to play video.");
            PlayVideo();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == interactableObject)
        {
            Debug.Log("Entered trigger area of interactable object.");
            isNearObject = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == interactableObject)
        {
            Debug.Log("Exited trigger area of interactable object.");
            isNearObject = false;
        }
    }

    void PlayVideo()
    {
        Debug.Log("Playing video.");
        canvas.enabled = true; // Habilita el Canvas
        videoPlayer.Play(); // Reproduce el video
    }
}
