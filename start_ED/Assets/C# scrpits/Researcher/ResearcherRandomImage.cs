using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearcherRandomImage : MonoBehaviour
{
    public Sprite researcherImage;

    public void DocumentButtonClick()
    {
        DocumentButton documentbutton = GameObject.Find("Canvas").GetComponent<DocumentButton>();
        documentbutton.profile.sprite = researcherImage;
    }
}
