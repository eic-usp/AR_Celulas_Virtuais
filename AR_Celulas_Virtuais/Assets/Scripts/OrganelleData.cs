using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "TesteDados", menuName = "Teste", order = 0)]
public class OrganelleData : ScriptableObject
{
    [SerializeField] private LocalizedString organelleName;
    [SerializeField] private LocalizedString description;
    [SerializeField] private LocalizedAudioClip audio;

    public string Name => organelleName.GetLocalizedString();
    public string Description => description.GetLocalizedString();

    public AudioClip Audio => audio.LoadAsset();
}
