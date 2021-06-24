using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetButtonClick : MonoBehaviour
{
    public GameObject listPanel;
    int button_count=0;

    private void Start()
    {
        listPanel.SetActive(false);
    }
    public void ListButtonOnClick()
    {
        if (button_count == 0)
        {
            listPanel.SetActive(true);
            button_count = 1;
        }
        else if (button_count == 1)
        {
            listPanel.SetActive(false);
            button_count = 0;
        }
    }
}
