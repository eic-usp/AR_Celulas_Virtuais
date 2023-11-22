using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    private bool audioOn;
    [SerializeField] Image soundOff;
    [SerializeField] Image soundOn;

    void Start()
    {
        ImageBool();
    }

    public void DescriptionSound()
    {
        audioOn = !audioOn;
        if (audioOn == true)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }

        ImageBool();
    }

    private void ImageBool()
    {
        if (audioOn == false)
        {
            soundOn.enabled = true;
            soundOff.enabled = false;
        }
        else
        {
            soundOn.enabled = false;
            soundOff.enabled = true;
        }
    }
}
