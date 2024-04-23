using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RecolectarObjeto : MonoBehaviour
{
    private GameObject objetoCogido;
    private Rigidbody objetoCogidoRigidbody;
    private Transform objetoCogidoPadre;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (objetoCogido == null)
            {
                // Recoger objeto si no hay ninguno cogido
                Collider[] colliders = Physics.OverlapSphere(transform.position, 1f); // Ajusta el radio según tu necesidad
                foreach (Collider collider in colliders)
                {
                    if (collider.CompareTag("ObjetoInteractivo"))
                    {
                        objetoCogido = collider.gameObject;
                        objetoCogidoRigidbody = objetoCogido.GetComponent<Rigidbody>();
                        objetoCogidoPadre = objetoCogido.transform.parent;
                        objetoCogidoRigidbody.isKinematic = true;

                        // Desactivar el objeto para que no sea visible ni interactuable
                        objetoCogido.SetActive(false);
                        break;
                    }
                }
            }
            else
            {
                // Soltar objeto si ya hay uno cogido
                objetoCogidoRigidbody.isKinematic = false;

                // Activar el objeto y establecer su posición sobre el suelo
                objetoCogido.SetActive(true);
                objetoCogido.transform.position = transform.position + Vector3.up * 0.5f; // Ajusta la altura según sea necesario
                objetoCogido.transform.SetParent(objetoCogidoPadre);

                objetoCogido = null;
                objetoCogidoRigidbody = null;
                objetoCogidoPadre = null;
            }
        }
    }
}


