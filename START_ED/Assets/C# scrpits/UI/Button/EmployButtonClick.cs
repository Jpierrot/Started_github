﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployButtonClick : MonoBehaviour
{
    [SerializeField]
    private GameObject TOP_layout;
    [SerializeField]
    private GameObject Employ_TOP_layout;
    [SerializeField]
    private GameObject InterView_TOP_layout;
    [SerializeField]
    private GameObject MIDDLE_layout;
    [SerializeField]
    private GameObject Trait_MIDDLE_layout;
    [SerializeField]
    private GameObject InterView_MIDDLE_layout;
    [SerializeField]
    private GameObject serpins;
    [SerializeField]
    private Text Serpin_text;
    [SerializeField]
    private GameObject Trait_text_boxes;
    [SerializeField]
    private Text[] Trait_text;

    private void Start()
    {
        Trait_text = Trait_text_boxes.GetComponentsInChildren<Text>();
    }

    public void EmployButtonOnClick()
    {
        TOP_layout.SetActive(false);
        Employ_TOP_layout.SetActive(true);
        MIDDLE_layout.SetActive(false);
        Trait_MIDDLE_layout.SetActive(true);
        serpins.transform.gameObject.SetActive(false);
        Serpin_text.gameObject.SetActive(false);
    }

    public void EmployButton1OnClick() {
        CheckButtonClick buttonClick = GameObject.Find("Canvas").GetComponent<CheckButtonClick>();
        if (buttonClick.ButtonCount >= 3)
        {
            Employ_TOP_layout.SetActive(false);
            InterView_TOP_layout.SetActive(true);
            Trait_MIDDLE_layout.SetActive(false);
            InterView_MIDDLE_layout.SetActive(true);

            Trait_text[0].text = buttonClick.Trait_text[0].text;
            Trait_text[1].text = buttonClick.Trait_text[1].text;
            Trait_text[2].text = buttonClick.Trait_text[2].text;
        }
    }
}