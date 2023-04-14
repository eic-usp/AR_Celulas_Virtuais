using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsController : MonoBehaviour
{
    [SerializeField] private GameObject animalCellCombiner;
    [SerializeField] private GameObject plantCellCombiner;
    [SerializeField] private GameObject procarioticCellCombine;
    [SerializeField] private GameObject ImgOrganellsPanel;

    // Start is called before the first frame update
    void Start()
    {
        animalCellCombiner.SetActive(false);
        plantCellCombiner.SetActive(false);
        procarioticCellCombine.SetActive(false);
        ImgOrganellsPanel.SetActive(false);
    }
}
