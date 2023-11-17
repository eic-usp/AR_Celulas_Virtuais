using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetContent : MonoBehaviour
{
    [SerializeField] private OrganelleData organelleData;
    [SerializeField] private GameObject Box;
    [SerializeField] private TextMeshProUGUI organelleNameText;
    [SerializeField] private TextMeshProUGUI organelleDescriptionText;
    

    private void OnMouseDown() {
        
        Box.SetActive(true);
        organelleNameText.text = organelleData.Name;
        organelleDescriptionText.text = organelleData.Description;
    }

    private void CloseBox() { Box.SetActive(false);}
}
