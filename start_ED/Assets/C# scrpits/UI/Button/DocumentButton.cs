using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocumentButton : MonoBehaviour
{
    public Image profile;
    public void DocumentButtonOnClick()
    {
        EmployButtonClick employ = GameObject.Find("Canvas").GetComponent<EmployButtonClick>();

        employ.Trait_text[0].text = Researcher_Trait.Trait_Text[0];
        employ.Trait_text[1].text = Researcher_Trait.Trait_Text[1];
        employ.Trait_text[2].text = Researcher_Trait.Trait_Text[2];
    }
}
