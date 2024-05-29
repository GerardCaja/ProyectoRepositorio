using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject optionsCanvas; // Arrastra aquí el Canvas de opciones en el Inspector

    public void ShowOptions()
    {
        optionsCanvas.SetActive(true);
    }
}