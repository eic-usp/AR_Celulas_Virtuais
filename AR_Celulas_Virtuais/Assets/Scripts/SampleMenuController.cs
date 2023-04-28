using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleMenuController : MonoBehaviour
{
    public void BtnGoSample()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BtnGoCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void BtnQuiz()
    {
        SceneManager.LoadScene("QuizDemo");
    }
}
