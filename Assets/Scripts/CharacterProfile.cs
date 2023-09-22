using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDefaultInformation
{
    public readonly string Name = "모험가";
    public readonly int Level = 1;
    public readonly int EXP = 0;
    public readonly int MaxEXP = 10;
    public readonly int Gold = 10000;
}

public class CharacterProfile : MonoBehaviour
{
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _ratioEXP;
    [SerializeField] private Image _barEXP;
    [SerializeField] private TMP_Text _level;
    [SerializeField] private TMP_Text _gold;
    
    void Start()
    {
        CharacterDefaultInformation defaultValue = new();
        _name.text = defaultValue.Name;
        
        StringBuilder str = new StringBuilder();
        str.Append(defaultValue.EXP);
        str.Append(" / ");
        str.Append(defaultValue.MaxEXP);
        _ratioEXP.text = str.ToString();
        _barEXP.fillAmount = (float)(defaultValue.EXP) / defaultValue.MaxEXP;

        _level.text = defaultValue.Level.ToString();
        _gold.text = defaultValue.Gold.ToString();
    }
}
