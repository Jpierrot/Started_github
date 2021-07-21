using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottom_layout_button : MonoBehaviour
{
    [SerializeField]
    private GameObject MIDDLE_layout; //연구원 정보 창
    [SerializeField]
    private GameObject Shop_MIDDLE_layout; //상점 창
    [SerializeField]
    private GameObject Equipment_MIDDLE_layout;

    public void EquipmentButtonOnClick()
    {
        if (MIDDLE_layout.activeSelf==true)
        {
            MIDDLE_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
        else if (Shop_MIDDLE_layout.activeSelf == true)
        {
            Shop_MIDDLE_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
        
    }
    public void shopButtonOnClick()
    {
        if (MIDDLE_layout.activeSelf == true)
        {
            MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
        else if (Equipment_MIDDLE_layout.activeSelf == true)
        {
            Equipment_MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
    }
    public void researcherButtonOnClick()
    {
        if (Shop_MIDDLE_layout.activeSelf == true)
        {
            Shop_MIDDLE_layout.SetActive(false);
            MIDDLE_layout.SetActive(true);
        }
        else if (Equipment_MIDDLE_layout.activeSelf == true)
        {
            Equipment_MIDDLE_layout.SetActive(false);
            MIDDLE_layout.SetActive(true);
        }
    }
}
