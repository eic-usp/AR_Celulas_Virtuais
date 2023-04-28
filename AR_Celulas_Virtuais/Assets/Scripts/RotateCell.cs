using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCell : MonoBehaviour
{
    float speedRotation = 5f;
    [SerializeField] Camera mainCamera;
    [SerializeField] Slider slider; 
    float initialFoV;
    [SerializeField] GameObject Animal;
    [SerializeField] GameObject Plant;
    [SerializeField] GameObject Bacterial;   
    
    public void Start()
	{
		slider.onValueChanged.AddListener (delegate {ZoomController();});
        initialFoV = mainCamera.fieldOfView;  
	}

    public void ZoomController()
    {
        mainCamera.fieldOfView = initialFoV*slider.value;
    }

    private void RotateHeart()
    {
        if (Input.touchCount > 0)
        {
            Touch primaryTouch = Input.GetTouch(0);

            if (primaryTouch.phase == TouchPhase.Moved)
            {
                Vector2 directionRotation = new Vector2(primaryTouch.deltaPosition.y*-1, primaryTouch.deltaPosition.x*-1);
                transform.Rotate(directionRotation * speedRotation * Time.deltaTime, Space.World);
            }
        }       
    }

    public void ResetRotate()
    { 
        Animal.transform.eulerAngles = new Vector3 (0, 0, 0);
        Plant.transform.eulerAngles = new Vector3 (0, 0, 0);
        Bacterial.transform.eulerAngles = new Vector3 (0, 180, 0);
    }

    private void Update()
    {
        RotateHeart();
    }
}

