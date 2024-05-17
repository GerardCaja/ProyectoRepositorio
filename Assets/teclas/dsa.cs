using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dsa : MonoBehaviour
{
    public GameObject canvas;

    void OnTriggerEnter(Collider collider)
    {
        canvas.SetActive(true);
    }

    void OnTriggerExit(Collider collider)
    {
        canvas.SetActive(false);
    }
 
}
