using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(fileName = "TesteDados", menuName = "Teste", order = 0)]
public class OrganelleData : ScriptableObject
{
    [field:SerializeField] public string Name { get; private set; }
    [field:SerializeField, TextArea] public string Description { get; private set; }
    [field:SerializeField] public AudioClip Audio { get; private set; }

}
