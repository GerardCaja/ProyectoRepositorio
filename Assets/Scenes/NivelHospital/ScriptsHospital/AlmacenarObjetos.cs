using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlmacenarObjtos : MonoBehaviour
{
    public GameObject efectoRecoleccion; // Efecto visual que se muestra cuando se recolecta el objeto
    public Image imagenObjeto1; // Imagen del objeto recolectado 1
    public Image imagenObjeto2; // Imagen del objeto recolectado 2
    public Image imagenObjeto3; // Imagen del objeto recolectado 3
    public VictoriaHospital victoriaScript;

    private bool recolectado = false; // Flag para evitar recolección múltiple

    private void Start()
    {
        victoriaScript = GetComponentInParent<VictoriaHospital>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !recolectado) // Comprueba si el objeto colisionó con el jugador y no ha sido recolectado aún
        {
            Debug.Log("Recolectar objeto: " + gameObject.name); // Mensaje de depuración para verificar si se intenta recolectar el objeto

            recolectado = true; // Marca el objeto como recolectado para evitar que se recolecte múltiples veces
            Recolectar(); // Llama a la función para recolectar el objeto
        }
    }

    void Recolectar()
    {
        Debug.Log("Objeto recolectado y destruido: " + gameObject.name); // Mensaje de depuración para verificar si el objeto se recolecta y destruye correctamente

        victoriaScript.ObjetoRecogido();   

        // Destruye el objeto recolectable
        Destroy(gameObject);

        // Activa la imagen correspondiente en el Canvas
        if (imagenObjeto1 != null && !imagenObjeto1.gameObject.activeSelf)
        {
            imagenObjeto1.gameObject.SetActive(true);
        }
        else if (imagenObjeto2 != null && !imagenObjeto2.gameObject.activeSelf)
        {
            imagenObjeto2.gameObject.SetActive(true);
        }
        else if (imagenObjeto3 != null && !imagenObjeto3.gameObject.activeSelf)
        {
            imagenObjeto3.gameObject.SetActive(true);
        }
    }
}