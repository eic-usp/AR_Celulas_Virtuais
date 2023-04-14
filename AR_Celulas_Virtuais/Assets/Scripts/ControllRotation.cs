using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllRotation : MonoBehaviour
{
    private float rotate;
    private bool isRotating;
    private void Start()
    {
        isRotating = true;
    }

    private void Update() 
    {
        if (isRotating)
        {
            rotate += Time.deltaTime * 25f;
            transform.rotation = Quaternion.Euler(rotate, 0f, rotate);
        }
    }

    private void OnMouseUpAsButton()
    {
        if (isRotating)
        {
            isRotating = false;
        }
        else
        {
            isRotating = true;            
        }
    }
}

