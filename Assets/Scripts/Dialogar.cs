using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogar : MonoBehaviour
{
    public GameObject canvas; // Asigna el Canvas en el Inspector
    public float distanciaMaxima = 3f;

    void Update()
    {
        // Si se presiona la tecla "E"
        if (Input.GetKeyDown(KeyCode.E) && EstaCercaDelJugador())
        {
            // Activa el Canvas
            canvas.SetActive(true);
        }

        // Si se presiona la tecla "Escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Desactiva el Canvas
            canvas.SetActive(false);
        }
    }

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
