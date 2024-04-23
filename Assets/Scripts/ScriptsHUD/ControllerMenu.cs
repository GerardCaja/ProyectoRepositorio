using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerMenu : MonoBehaviour
{
    public GameObject canvasMenuPrincipal; // Asegúrate de asignar el canvas del menú desde el Editor de Unity
    public GameObject canvasOpciones; // Asegúrate de asignar el canvas de opciones desde el Editor de Unity
    public Button botonOpciones; // Asegúrate de asignar el botón de opciones desde el Editor de Unity
    public Button botonBack; // Asegúrate de asignar el botón de back desde el Editor de Unity


    void Start()
    {
        // Asegúrate de desactivar el canvas de opciones al inicio si no deseas que esté activo por defecto
        canvasOpciones.SetActive(false);

        // Suscribir la función MostrarOpciones al evento de clic del botón
        botonOpciones.onClick.AddListener(MostrarOpciones);

        // Suscribir la función VolverAlMenu al evento de clic del botón "back"
        botonBack.onClick.AddListener(VolverAlMenu);
    }

    public void MostrarOpciones()
    {
        // Activa el canvas de opciones
        canvasOpciones.SetActive(true);
        canvasMenuPrincipal.SetActive(false); // Asegúrate de ocultar el canvas del menú al mostrar el canvas de opciones
    }

    public void VolverAlMenu()
    {
        canvasOpciones.SetActive(false);
        canvasMenuPrincipal.SetActive(true);
    }
}
