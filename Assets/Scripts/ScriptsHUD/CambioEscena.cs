using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Nombre de la escena del puzzle
    private LevelLoader levelLoader;

    // Distancia máxima a la que el jugador puede estar para activar el minijuego
    public float distanciaMaxima = 3f;

    private void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>();
    }

    void Update()
    {
        // Verificar si se presiona la tecla "E" y el jugador está cerca del objeto
        if (Input.GetKeyDown(KeyCode.E) && EstaCercaDelJugador())
        {
            // Cargar la escena del puzzle
            levelLoader.LoadLevel("Puzzle");
        }
    }

    // Método para verificar si el jugador está cerca del objeto
    bool EstaCercaDelJugador()
    {
        // Calcular la distancia entre el jugador y el objeto
        float distancia = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);

        // Devolver verdadero si la distancia es menor o igual a la distancia máxima permitida
        return distancia <= distanciaMaxima;
    }

    // Método para dibujar un gizmo visualizando el área de activación (solo para propósitos de edición)
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaMaxima);
    }
}

