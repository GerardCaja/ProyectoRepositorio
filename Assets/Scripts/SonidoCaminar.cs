using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoCaminar : MonoBehaviour
{
    public AudioClip footstepClip; // Sonido de pasos
    private AudioSource footstepSource; // Referencia al AudioSource

    [Range(0.1f, 1.0f)] // Definir el rango mínimo y máximo para el intervalo entre pasos
    public float stepInterval = 0.5f; // Intervalo entre cada paso

    private float nextStepTime; // Tiempo para el próximo paso

    private bool isWalking = false; // Indica si el personaje está caminando

    void Start()
    {
        // Crea un AudioSource dinámicamente
        footstepSource = gameObject.AddComponent<AudioSource>();
        footstepSource.clip = footstepClip;
    }

    void Update()
    {
        // Detecta el movimiento del personaje (puedes adaptar esta lógica según tu implementación)
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            if (!isWalking)
            {
                // El personaje ha comenzado a caminar
                isWalking = true;
                nextStepTime = Time.time; // Inicia el tiempo para el próximo paso
                PlayFootstepSound();
            }
            else if (Time.time >= nextStepTime && !footstepSource.isPlaying)
            {
                // Reproduce el sonido de pasos si no está ya reproduciéndose
                PlayFootstepSound();
            }
        }
        else
        {
            // El personaje ha dejado de caminar
            isWalking = false;
        }
    }

    // Método para reproducir el sonido de pasos
    void PlayFootstepSound()
    {
        footstepSource.PlayOneShot(footstepClip); // Reproduce el sonido de pasos
        nextStepTime = Time.time + stepInterval; // Actualiza el tiempo para el próximo paso
    }
}
