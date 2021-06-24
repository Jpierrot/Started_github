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
    [SerializeField]
    private Text change_text;
    private bool isShop = false;
    private void Start()
    {
    }
    public void shopButtonOnClick()
    {
        if (!isShop)
        {
            MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
            change_text.text = "홈으로";
            isShop = true;
        }
        else if (isShop)
        {
            Shop_MIDDLE_layout.SetActive(false);
            MIDDLE_layout.SetActive(true);
            change_text.text = "상점";
            isShop = false;
        }
    }
}
