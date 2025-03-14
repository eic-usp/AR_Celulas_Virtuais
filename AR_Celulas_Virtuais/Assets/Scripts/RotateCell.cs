using UnityEngine;
public class RotateCell : MonoBehaviour
{
    [SerializeField] private float speedRotation = 5f;
    [SerializeField] Camera mainCamera;

    private void Rotate()
    {
        if (Input.touchCount <= 0) return;
        
        var primaryTouch = Input.GetTouch(0);
        if (primaryTouch.phase != TouchPhase.Moved) return;
        
        var directionRotation = new Vector2(primaryTouch.deltaPosition.y*-1, primaryTouch.deltaPosition.x*-1);
        transform.Rotate(directionRotation * (speedRotation * Time.deltaTime), Space.World);
    }

    private void Update()
    {
        Rotate();
    }
}

