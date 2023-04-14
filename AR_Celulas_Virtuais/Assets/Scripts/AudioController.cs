using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // // Script controla o audio de cada organella que aparece eno painel.
    // // Script deve esta no objeto imgorgane
    [SerializeField] private GameObject animalCell;
    [SerializeField] private GameObject plantCell;
    [SerializeField] private GameObject procariotiCell;
    [SerializeField] private GameObject imgOrganellPainel;

    private void Start() 
    {
     animalCell.GetComponent<AudioSource>().Stop();
     plantCell.GetComponent<AudioSource>().Stop();
     procariotiCell.GetComponent<AudioSource>().Stop();
    }


    public void BtnCloseImgOrganellsPanel()
    {
         imgOrganellPainel.SetActive(false);
    }
}
