using System.Collections;
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
    private GameObject MIDDLE_layout;
    [SerializeField]
    private GameObject Trait_MIDDLE_layout;
    [SerializeField]
    private GameObject serpins;
    [SerializeField]
    private Text Serpin_text;

    public void EmployButtonOnClick()
    {
        TOP_layout.SetActive(false);
        Employ_TOP_layout.SetActive(true);
        MIDDLE_layout.SetActive(false);
        Trait_MIDDLE_layout.SetActive(true);
        serpins.transform.gameObject.SetActive(false);
        Serpin_text.gameObject.SetActive(false);
    }

    public void UnEmployButtonOnClick() {
        TOP_layout.SetActive(true);
        Employ_TOP_layout.SetActive(false);
        MIDDLE_layout.SetActive(true);
        Trait_MIDDLE_layout.SetActive(false);
        serpins.transform.gameObject.SetActive(true);
        Serpin_text.gameObject.SetActive(true);
    }
}
