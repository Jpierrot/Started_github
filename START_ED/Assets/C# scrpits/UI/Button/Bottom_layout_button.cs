using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottom_layout_button : MonoBehaviour
{
    [SerializeField]
    private GameObject MIDDLE_layout;
    [SerializeField]
    private GameObject Shop_MIDDLE_layout;
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
