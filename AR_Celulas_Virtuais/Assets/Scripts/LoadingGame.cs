using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadingGame : MonoBehaviour
{
    [SerializeField]    private TextMeshProUGUI textPorcent;

    [SerializeField]    private Button buttonLoading;

    [SerializeField]    private Image imageLoading;

    [SerializeField]    private GameObject loadingContent;
    [SerializeField]    private String nameScene;

 
    void Start()
    {
        buttonLoading.onClick.AddListener(LoadButton);
        imageLoading.fillAmount = 0;
        textPorcent.text = "";
    }

    void LoadButton()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds (1);
        System.GC.Collect();
        loadingContent.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(nameScene);
        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            textPorcent.text = "Aguarde carregando: " + (asyncOperation.progress * 100).ToString("N0") +" % ";
            imageLoading.fillAmount = asyncOperation.progress;

            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return new WaitForEndOfFrame();
        }
    }
}
