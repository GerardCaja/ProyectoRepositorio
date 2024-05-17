using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saberteclas : MonoBehaviour
{
    Transform _camera;

    void Start()
    {
        _camera = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(_camera);
    }
}
