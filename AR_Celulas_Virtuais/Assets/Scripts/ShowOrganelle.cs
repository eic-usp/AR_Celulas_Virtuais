using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowOrganelle : MonoBehaviour
{
    [SerializeField] private GameObject ImgOrganellsPainel;
    [SerializeField] private GameObject[] imgOrganelleSelect;

    //Ester script deve ser colocado em cada organella.
    //1º arrastar os paineis ImgOrganellsPainel, imgOrganelleSelect e arrastar a lista de imagens em ordem listOrganelles
    private void OnMouseDown()
    {
        switch (gameObject.name)
        {
            //Lista 0
            case "centriole":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[0].SetActive(true);
                break;

            //list 1
            case "chloroplast":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[1].SetActive(true);
                break;

            //list 2
            case "Citoesqueleto":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[2].SetActive(true);
                break;

            //list 3
            case "Complexo_Goldi_Att":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[3].SetActive(true);
                break;

            //list 4
            case "lysosome":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[4].SetActive(true);
                break;

            //list 5
            case "mitochondrion":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[5].SetActive(true);
                break;

            //list 6
            case "nucleus":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[6].SetActive(true);
                break;

            //list 7
            case "peroxisome":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[7].SetActive(true);
                break;

            //list 8
            case "plasma_membrane":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[8].SetActive(true);
                break;

            //list 9
            case "ReticuloLiso":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[9].SetActive(true);
                break;

            //list 10
            case "ReticuloRugoso":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[10].SetActive(true);
                break;

            //list 11
            case "ribosome":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[11].SetActive(true);
                break;


            //list 12
            case "vacuole":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[12].SetActive(true);
                break;

            case "cytosol":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[13].SetActive(true);
                break;


            case "fimbrias":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[14].SetActive(true);
                break;

            case "Pili":
                ImgOrganellsPainel.SetActive(true);
                //ImgOrganellsPainel.GetComponent<Image>().enabled = false; Abre o painel, mas desabilita a imagem, para ficar apenas o audio

                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[15].SetActive(true);
                break;

            case "Flagellum":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[16].SetActive(true);
                break;

            case "materialGenetico":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[17].SetActive(true);
                break;

            case "CellWall_Borda":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[18].SetActive(true);
                break;

            case "plasmideo":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[19].SetActive(true);
                break;

            case "Leukoplast":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[20].SetActive(true);
                break;

            case "Plasmodesmata":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[21].SetActive(true);
                break;

            case "ribosome_bac":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[22].SetActive(true);
                break;

            case "PlasmaMembrane_Borda":
            ImgOrganellsPainel.SetActive(true);
            CloseAllPaneelsOrganelles();

            imgOrganelleSelect[23].SetActive(true);
            break;

            case "cytosol_bac":
                ImgOrganellsPainel.SetActive(true);
                CloseAllPaneelsOrganelles();

                imgOrganelleSelect[24].SetActive(true);
                break;

            default:
                Debug.Log("Estrutura não encontrada"); // deixe como padrão alguma informação que ainda não ocorrido
                break;
        }
    }

    private void CloseAllPaneelsOrganelles()
    {
        for (int i = 0; i < imgOrganelleSelect.Length; i++)
        {
            imgOrganelleSelect[i].SetActive(false);
        }
    }

}



