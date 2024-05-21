using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escuelaCompletion : MonoBehaviour
{
    private LevelLoader levelLoader;


    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Completado();
        }
    }

    public void Completado()
    {
        levelLoader.LoadLevel("EndGame");
    }

}
