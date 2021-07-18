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
    private void Start()
    {
    }
    public void shopButtonOnClick()
    {
        Shop_MIDDLE_layout.SetActive(true);
        MIDDLE_layout.SetActive(false);
    }
    public void researcherButtonOnClick()
    {
        Shop_MIDDLE_layout.SetActive(false);
        MIDDLE_layout.SetActive(true);
    }
}
