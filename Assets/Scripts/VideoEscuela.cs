using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoEscuela : MonoBehaviour
{
    private LevelLoader levelLoader;
    public GameObject interactableObject; // El objeto con el que interactuamos
    public VideoPlayer videoPlayer; // El VideoPlayer
    public GameObject canvas; // El Canvas que contiene el video
    public AudioSource bgMusic;

    private bool isNearObject = false;

    void Start()
    {
        bgMusic = FindObjectOfType<AudioSource>().GetComponent<AudioSource>();
        levelLoader = FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>();
    }
    void Update()
    {
        if (isNearObject && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Key pressed and near object. Attempting to play video.");
            PlayVideo();
            bgMusic.mute = true;
        }

        videoPlayer.loopPointReached += OnVideoEnd;
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

    void OnVideoEnd(VideoPlayer vp)
    {
        bgMusic.mute = false;
        Completado();
    }

    public void Completado()
    {
        levelLoader.LoadLevel("EndGame");
    }

    void PlayVideo()
    {
        Debug.Log("Playing video.");
        canvas.SetActive(true); // Habilita el Canvas
        videoPlayer.Play(); // Reproduce el video
    }


    
}
