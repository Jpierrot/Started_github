using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedEmployButton : MonoBehaviour
{
    [SerializeField]
    private GameObject interview_TOP_Layout;
    [SerializeField]
    private GameObject interview_MiDDLE_Layout;
    [SerializeField]
    private GameObject MIDDLE_Layout;
    [SerializeField]
    private GameObject TOP_Layout;

    [SerializeField]
    private Image[] researcherimage;

    [SerializeField]
    private GameObject serpins;

    [SerializeField]
    private int buttonClickCount = 0;
    // Start is called before the first frame update
    
    public void RedEmployButtonOnClick()
    {
        interview_TOP_Layout.SetActive(false);
        interview_MiDDLE_Layout.SetActive(false);
        TOP_Layout.SetActive(true);
        MIDDLE_Layout.SetActive(true);
        serpins.transform.gameObject.SetActive(true);
        Serpin_Create.serpin_check = true;
        DocumentButton documentButton = GameObject.Find("Canvas").GetComponent<DocumentButton>();

        if (buttonClickCount < 5)
        {
            researcherimage[buttonClickCount].sprite = documentButton.profile.sprite;
            buttonClickCount++;
        }
    }
}
