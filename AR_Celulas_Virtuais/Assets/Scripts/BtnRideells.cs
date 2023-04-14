using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnRideells : MonoBehaviour
{
    // Ao Clicar em um Botão de célula, todos as outras celulas serão apagadas.

    //UI Variables
    [SerializeField] private Button BtnAnimalCell;
    [SerializeField] private Button BtnVegetalCell;
    [SerializeField] private Button BtnProcariotica;

    //Cell GameObjects Variables
    [SerializeField] private GameObject AnimalCell;
    [SerializeField] private GameObject VegetalCell;
    [SerializeField] private GameObject Procariotica;
    [SerializeField] private GameObject ImgOrganellsPainel;

    void Start()
    {   //Houve o Click no botão da célula Animal
        BtnAnimalCell = BtnAnimalCell.GetComponent<Button>();
        BtnAnimalCell.onClick.AddListener(ShowAnimalCell);

        //Houve o Click no botão das célula Vegetal
        BtnVegetalCell = BtnVegetalCell.GetComponent<Button>();
        BtnVegetalCell.onClick.AddListener(ShowVegetalCell);        

        //Houve o click na celula Procariótica
        BtnProcariotica = BtnProcariotica.GetComponent<Button>();
        BtnProcariotica.onClick.AddListener(ShowProcarioticaCell);
    }

    private void ShowAnimalCell()
    {
        AnimalCell.SetActive(true);
        Procariotica.SetActive(false);
        VegetalCell.SetActive(false);
        ImgOrganellsPainel.SetActive(false);
    }

    private void ShowVegetalCell()
    {
        AnimalCell.SetActive(false);
        Procariotica.SetActive(false);
        VegetalCell.SetActive(true);
        ImgOrganellsPainel.SetActive(false);

    }

    private void ShowProcarioticaCell()
    {
        AnimalCell.SetActive(false);
        Procariotica.SetActive(true);
        VegetalCell.SetActive(false);
        ImgOrganellsPainel.SetActive(false);

    }

}
