using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class CharacterProfile : MonoBehaviour
{
    public readonly string Name = "모험가";

    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text EXP;
    
    void Start()
    {
        _name.text = Name;
    }
}
