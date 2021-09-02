using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButtonClick : MonoBehaviour
{
    [SerializeField]
    private GameObject Content;

    public Text[] Trait_text = new Text[3];

    [SerializeField]
    private Text[] Trait_Button_Text = new Text[9];

    public Button[] Check_Button;

    public int ButtonCount=0;

    private void Start()
    {

        Trait_Button_Text = Content.GetComponentsInChildren<Text>();
        Check_Button = Content.GetComponentsInChildren<Button>();

        for (int i = 0; i < Check_Button.Length; ++i) {
            int index = i;
            Check_Button[i].onClick.AddListener(() => OnClickEvent(index));
        }

        void OnClickEvent(int index) {
            if (ButtonCount < 3) 
            {
                if (Check_Button[index].transform.GetChild(0).gameObject.activeSelf == false)
                    {
                    ButtonCount++;
                    Check_Button[index].transform.GetChild(0).gameObject.SetActive(true);
                        Trait_text[ButtonCount-1].text += Trait_Button_Text[index].text;
                    }
            }
        }
    }

    /*
    public void CheckButtonOnClick_0()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[0].transform.GetChild(0).gameObject.activeSelf==false)
            {
                ButtonCount++;
                Check_Button[0].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[0].text;break;
                    case 2: Trait_text[1].text += Trait_Button_Text[0].text;break;
                    case 3: Trait_text[2].text += Trait_Button_Text[0].text;break;
                }
            }
        }           
    }
    public void CheckButtonOnClick_1()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[1].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[1].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[1].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[1].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[1].text; break;
                }
            }
        }
    }
    public void CheckButtonOnClick_2()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[2].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[2].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[2].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[2].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[2].text; break;
                }
            }
        }
    }
    public void CheckButtonOnClick_3()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[3].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[3].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[3].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[3].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[3].text; break;
                }
            }
        }
    }
    public void CheckButtonOnClick_4()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[4].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[4].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[4].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[4].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[4].text; break;
                }
            }
        }
    }
    public void CheckButtonOnClick_5()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[5].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[5].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[5].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[5].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[5].text; break;
                }
            }
        }
    }
    public void CheckButtonOnClick_6()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[6].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[6].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[6].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[6].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[6].text; break;
                }
            }
        }
    }
    public void CheckButtonOnClick_7()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[7].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[7].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[7].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[7].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[7].text; break;
                }
            }
        }
    }
    public void CheckButtonOnClick_8()
    {
        if (ButtonCount < 3)
        {
            if (Check_Button[8].transform.GetChild(0).gameObject.activeSelf == false)
            {
                ButtonCount++;
                Check_Button[8].transform.GetChild(0).gameObject.SetActive(true);
                switch (ButtonCount)
                {
                    case 1: Trait_text[0].text += Trait_Button_Text[8].text; break;
                    case 2: Trait_text[1].text += Trait_Button_Text[8].text; break;
                    case 3: Trait_text[2].text += Trait_Button_Text[8].text; break;
                }
            }
        }
    }
    */
}
