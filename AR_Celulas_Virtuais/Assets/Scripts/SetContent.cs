using UnityEngine;

public class SetContent : MonoBehaviour
{
    [SerializeField] private OrganelleData organelleData;
    
    public void OnMouseUp()
    {
        // if (Input.touchCount <= 0) return;
        //
        // var primaryTouch = Input.GetTouch(0);
        // if (primaryTouch.phase != TouchPhase.Stationary) return;
        
        ContentManager.Instance.SetContent(organelleData);
    }
}
