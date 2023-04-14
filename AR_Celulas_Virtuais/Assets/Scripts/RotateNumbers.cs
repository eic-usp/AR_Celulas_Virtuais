using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNumbers : MonoBehaviour
{
  
      /* 
         Classe que controla a rotação dos números,
         deixando-os alinhados com a rotação da câmera.
      */
     [SerializeField] Transform cameraTransform;

     void Update()
     {
        Vector3 camera_direction =  cameraTransform.forward;

        transform.forward = camera_direction;
        
     }
}
