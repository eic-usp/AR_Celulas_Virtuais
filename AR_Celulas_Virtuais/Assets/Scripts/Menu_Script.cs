using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{


    public void goInitialScene() => SceneManager.LoadScene(1); 

    public GameObject CanvaMenu;
    public GameObject CanvaCredits;


    // Start is called before the first frame update
    void Start()
    {
        CanvaMenu.SetActive(true);
        CanvaCredits.SetActive(false);
    
    }

    public void GoCredits(){
        CanvaMenu.SetActive(false);
        CanvaCredits.SetActive(true);
    
    }

    public void BackCredits(){
        CanvaMenu.SetActive(true);
        CanvaCredits.SetActive(false);
        
    }

}
