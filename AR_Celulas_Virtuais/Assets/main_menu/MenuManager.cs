using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{


    public GameObject CanvaMenu;
    public GameObject CanvaCredits;






    // Start is called before the first frame update
    void Start()
    {
        CanvaMenu.SetActive(true);
        CanvaCredits.SetActive(false);
        
    }

    //Carregar cena principal
    public void LoadScene() =>  SceneManager.LoadScene(1);

    public void GoCredits(){
        
        CanvaMenu.SetActive(false);
        CanvaCredits.SetActive(true);
        
    }


    public void BackCredits(){
        
        CanvaMenu.SetActive(true);
        CanvaCredits.SetActive(false);
        
    }



}
