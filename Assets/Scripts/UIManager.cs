using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    
    [SerializeField] private GameObject mainPageBtns;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button statusButton;
    [SerializeField] private GameObject invenImage;
    [SerializeField] private GameObject statusImage;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        mainPageBtns.SetActive(true);
        invenImage.SetActive(false);
        statusImage.SetActive(false);
    }

    public void ClickStatus()
    {
        statusImage.SetActive(true);
        mainPageBtns.SetActive(false);
    }
    
    public void ClickInventory()
    {
        invenImage.SetActive(true);
        mainPageBtns.SetActive(false);
    }

    public void ReturnToMainPage()
    {
        invenImage.SetActive(false);
        statusImage.SetActive(false);
        mainPageBtns.SetActive(true);
    }
}
