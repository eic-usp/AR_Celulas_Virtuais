using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoCellParts : MonoBehaviour
{

    /*
        Classe que controla o painel de informações
        de cada organela. 
    */
    //[SerializeField] string namePart;
    [SerializeField] string descriptionPart;
 
    [SerializeField] GameObject infoPanel;

    /*private void start() 
    {
        GetInfo();     
    } */   

    /* 
        Método que pega as informações das organelas
        e manda para o painel.
    */
    private void OnMouseUpAsButton()
    {

        //Text textPartName = infoPanel.transform.GetChild(1).gameObject.GetComponent<Text>();
        Text textPartDescription = infoPanel.transform.GetChild(1).gameObject.GetComponent<Text>();
        //textPartName.text = namePart;
        textPartDescription.text = descriptionPart;

    }

}
        