using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListButtonClick : MonoBehaviour
{
    public GameObject Button_list_Panel;
    int button_count=0;

    private void Start()
    {
        Button_list_Panel.SetActive(false);
    }
    public void ListButtonOnClick()
    {
        if (button_count == 0)
        {
            Button_list_Panel.SetActive(true);
            button_count = 1;
        }
        else if (button_count == 1)
        {
            Button_list_Panel.SetActive(false);
            button_count = 0;
        }
    }
}
