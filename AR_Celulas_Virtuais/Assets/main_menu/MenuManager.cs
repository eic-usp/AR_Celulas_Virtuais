using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuuManager : MonoBehaviour
{


    public GameObject CanvaMenu;
    public GameObject CanvaCredits;
    public GameObject CanvaTutorial;





    // Start is called before the first frame update
    void Start()
    {
        CanvaMenu.SetActive(true);
        CanvaCredits.SetActive(false);

    }

    //Carregar cena principal
    public void LoadScene() => SceneManager.LoadScene(1);

    public void GoCredits()
    {

        CanvaMenu.SetActive(false);
        CanvaCredits.SetActive(true);

    }


    public void BackCredits()
    {

        CanvaMenu.SetActive(true);
        CanvaCredits.SetActive(false);

    }

    public void GoTutorial()
    {

        CanvaMenu.SetActive(false);
        CanvaTutorial.SetActive(true);

    }

    public void BackTutorial()
    {

        CanvaMenu.SetActive(true);
        CanvaTutorial.SetActive(false);

    }
}
