using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnEvents : MonoBehaviour
{
    [SerializeField] private GameObject target;
    
    public void OnBtnClick()
    {
        Camera.main.GetComponent<MouseOrbitSample>().RefreshCamera(target.transform.Find("_cameraDirection"), 1f, 2f);
        GameManager.ActiveCell = target;

    }

}
