using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject MIDDLE_ScrollerRect_Researcher;
    [SerializeField]
    private GameObject MIDDLE_ScrollerRect_Fiannce;
    [SerializeField]
    private GameObject MIDDLE_ScrollerRect_Maketing;
    [SerializeField]
    private GameObject Home_MIDDLE_layout;

    public void Development()
    {
        Home_MIDDLE_layout.SetActive(false);
        MIDDLE_ScrollerRect_Researcher.SetActive(true);
        Debug.Log(MIDDLE_ScrollerRect_Researcher.activeSelf);
    }
}
