using UnityEngine;
public class RotateCell : MonoBehaviour
{
    [SerializeField] private float speedRotation = 5f;
    [SerializeField] Camera mainCamera;

    private void RotateHeart()
    {
        if (Input.touchCount > 0)
        {
            Touch primaryTouch = Input.GetTouch(0);

            if (primaryTouch.phase == TouchPhase.Moved)
            {
<<<<<<< Updated upstream
                Vector2 directionRotation = new Vector2(primaryTouch.deltaPosition.y*-1, primaryTouch.deltaPosition.x*-1);
                transform.Rotate(directionRotation * speedRotation * Time.deltaTime, Space.World);
=======
                Vector2 directionRotation = new Vector2(primaryTouch.deltaPosition.y*1, primaryTouch.deltaPosition.x*-1);
                transform.Rotate(directionRotation * (speedRotation * Time.deltaTime), Space.World);
>>>>>>> Stashed changes
            }
        }       
    }

    private void Update()
    {
        RotateHeart();
    }
}

