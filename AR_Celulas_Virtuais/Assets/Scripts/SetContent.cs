using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;

public class SetContent : MonoBehaviour
{
    [SerializeField] private OrganelleData organelleData;
    [SerializeField] private GameObject Box;
    [SerializeField] private TextMeshProUGUI organelleNameText;
    [SerializeField] private TextMeshProUGUI organelleDescriptionText;
    [SerializeField] private AudioSource organelleAudio;


    private void OnMouseDown()
    {

        Box.SetActive(true);
        organelleNameText.text = organelleData.Name;
        organelleDescriptionText.text = organelleData.Description;
        organelleAudio.clip = organelleData.Audio;
        organelleAudio.Play();

    }
}
