using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnAudio : MonoBehaviour
{

    /*  
        Classe que adiciona funcionalidade no botão de áudio 
        do painel de cada organela. 
    */
    [SerializeField] AudioSource imgPanelAudioSource;

    /* 
        Evento que verifica quando o botão é clicado. Se o 
        áudio não estiver sendo tocado, é iniciado. Se o 
        áudio estiver tocando, ele para.
    */
    public void BtnClicked()
    {
        if (imgPanelAudioSource.isPlaying)
        {
            StopAudio();
        }
        else
        {
            PlayAudio();
        }
    }

    /*
        Métodos auxiliares para o evento de clique.
    */
    public void StopAudio()
    {
        imgPanelAudioSource.Stop();
    }

    void PlayAudio()
    {
        imgPanelAudioSource.Play();
    }
    
}
