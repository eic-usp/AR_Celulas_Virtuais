using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoom : MonoBehaviour
{
    //Cell GameObjects Variables
    [SerializeField]    private GameObject targetAnimal; // Camera foca na celula animal
    [SerializeField]    private GameObject targetPlant; // Camera foca na celula vegetal
    [SerializeField]    private GameObject targetProcariotic; // Camera foca na celula procariotica

    //UI Button Variables
    [SerializeField] private Button BtnAnimalCell;
    [SerializeField] private Button BtnVegetalCell;
    [SerializeField] private Button BtnProcariotica;



    public float zoomSpeed = 3.0f; // velocidade de zoom


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

    public void BtnClickZoomCel()
    {
        StartCoroutine(ZoomIn());
    }

    IEnumerator ZoomIn()
    {
        float step = zoomSpeed * Time.deltaTime;
        while (Vector3.Distance(Camera.main.transform.position, targetAnimal.transform.position) > 1.0f)
        {
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, targetAnimal.transform.position, step);
            yield return null;
        }
    }


    
    private void ShowAnimalCell()
    {
        targetAnimal.SetActive(true);
        targetProcariotic.SetActive(false);
        targetPlant.SetActive(false);
    }

    private void ShowVegetalCell()
    {
        targetAnimal.SetActive(false);
        targetProcariotic.SetActive(false);
        targetPlant.SetActive(true);

    }

    private void ShowProcarioticaCell()
    {
        targetAnimal.SetActive(false);
        targetProcariotic.SetActive(true);
        targetPlant.SetActive(false);
    }
}