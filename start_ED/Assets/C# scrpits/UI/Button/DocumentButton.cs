using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocumentButton : MonoBehaviour
{
    public Image profile;
    public void DocumentButtonOnClick()
    {
        //Researcher_Trait researcher = GameObject.Find("Document").GetComponent<Researcher_Trait>();
        EmployButtonClick employ = GameObject.Find("Canvas").GetComponent<EmployButtonClick>();
        ResearcherRandomImage image = GameObject.Find("Canvas").GetComponent<ResearcherRandomImage>();

        employ.Trait_text[0].text = Researcher_Trait.Trait_Text[0];
        employ.Trait_text[1].text = Researcher_Trait.Trait_Text[1];
        employ.Trait_text[2].text = Researcher_Trait.Trait_Text[2];


        int rand = Random.Range(0, 2);
        profile.sprite = image.researcherImage[rand];
    }
}
