using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogar : MonoBehaviour
{
    public GameObject canvas; // Asigna el Canvas en el Inspector
    public float distanciaMaxima = 3f;
    private DialogueAnimation dialAnimScript;

    private void Start()
    {
        dialAnimScript = GetComponent<DialogueAnimation>();
    }

    void Update()
    {
        // Si se presiona la tecla "E" y el jugador está cerca
        if (Input.GetKeyDown(KeyCode.E) && EstaCercaDelJugador())
        {
            // Cambia el estado de activación del Canvas (si está activo, lo desactiva y viceversa)
            canvas.SetActive(!canvas.activeSelf);
            if(canvas)
            {
                dialAnimScript.dialogueIndex = 0;
            }
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
