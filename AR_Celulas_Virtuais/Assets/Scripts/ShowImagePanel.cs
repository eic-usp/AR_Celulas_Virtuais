using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImagePanel : MonoBehaviour
{

    /*
        Classe que controla o painel de informações
        de cada organela. 
    */
    [SerializeField] string namePart;
    [SerializeField] GameObject imgPart;
    [SerializeField] GameObject ImagePanel;
    [SerializeField] AudioClip descriptionAudio;
    [SerializeField] GameObject containerButton;
    string tagName = "Button";


    /* 
        Evento que controla quando o usuário clica em
        alguma organela. Se não tiver nenhum painel ativo
        o painel da organela clicada aparece;
    */
    void OnMouseUpAsButton()
    {

        if (ImagePanel.activeSelf == false)
        {
            ImagePanelShow();
        }
        else if(ImagePanel.activeSelf == true)
        {
            imgPart.SetActive(false);
            ImagePanel.SetActive(false);
            containerButton.SetActive(true);
        }
        
    }


    /* 
        Método que pega as informações das organelas
        e manda para o painel. Depois, ativa ele.
    */
    private void ImagePanelShow()
    {

        AudioSource audioSource = ImagePanel.GetComponent<AudioSource>(); 
        audioSource.clip = descriptionAudio;

        ImagePanel.SetActive(true);
        imgPart.SetActive(true);

        containerButton = GameObject.FindGameObjectWithTag(tagName);
        containerButton.SetActive(false);

        Text textPartName = ImagePanel.transform.GetChild(2).gameObject.GetComponent<Text>();
        textPartName.text = namePart;

    }

}
        