using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicadorInteraccion : MonoBehaviour
{
    public Sprite spriteQ; // Asigna la imagen de la letra "Q" desde el Inspector o desde el proyecto
    public float distanciaMostrar = 2f; // Distancia a la que el indicador se mostrará

    private GameObject indicador; // Referencia al GameObject del indicador
    private Transform jugador; // Referencia al transform del jugador

    void Start()
    {
        // Crea un nuevo GameObject para el indicador
        indicador = new GameObject("Indicador");

        // Lo coloca como hijo del objeto actual
        indicador.transform.parent = transform;

        // Agrega un SpriteRenderer al GameObject del indicador
        SpriteRenderer renderer = indicador.AddComponent<SpriteRenderer>();
        renderer.sprite = spriteQ; // Asigna el sprite de la letra "Q"

        // Ajusta el tamaño del indicador
        indicador.transform.localScale = new Vector3(0.000867106f, 0.000873332f, 0.01041023f);

        // Desactiva el indicador al inicio
        indicador.SetActive(false);

        // Obtén la referencia al transform del jugador
        jugador = GameObject.FindGameObjectWithTag("Player").transform;

        indicador.transform.localPosition = new Vector3(0.001f, -0.00145f, 0.0136f);
    }

    void Update()
    {
        // Calcula la distancia entre el objeto y el jugador
        float distancia = Vector3.Distance(transform.position, jugador.position);

        // Muestra u oculta el indicador según la distancia
        if (distancia <= distanciaMostrar)
        {
            indicador.SetActive(true);
        }
        else
        {
            indicador.SetActive(false);
        }

        // Orienta el indicador hacia la cámara del jugador
        indicador.transform.LookAt(indicador.transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
    }
}
