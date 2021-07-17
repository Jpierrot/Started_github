using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Researcher_Trait : MonoBehaviour
{
    static public string[] Trait_Text = new string[3];

    private void OnEnable()
    {
        CheckButtonClick buttonClick = GameObject.Find("Canvas").GetComponent<CheckButtonClick>();

        Trait_Text[0] = buttonClick.Trait_text[0].text;
        Trait_Text[1] = buttonClick.Trait_text[1].text;
        Trait_Text[2] = buttonClick.Trait_text[2].text;
    }
}