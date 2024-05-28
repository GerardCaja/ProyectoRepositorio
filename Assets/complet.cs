using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class complet : MonoBehaviour
{
    private LevelLoader levelLoader;
    private VideoPlayer videoPlayer;

    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>();
        videoPlayer = GetComponent<VideoPlayer>();

        // Suscribirse al evento loopPointReached del VideoPlayer
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Método que se llamará cuando termine el video
    void OnVideoEnd(VideoPlayer vp)
    {
        Completado();
    }

    public void Completado()
    {
        levelLoader.LoadLevel("EndGame");
    }
}