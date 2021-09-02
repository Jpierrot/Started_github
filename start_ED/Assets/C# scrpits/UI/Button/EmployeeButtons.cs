using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject Researcher_MIDDLE_layout;
    [SerializeField]
    private GameObject Home_MIDDLE_layout;
    [SerializeField]
    private GameObject Researcher_layout;
    [SerializeField]
    private GameObject Sales_MIDDLE_layout;
    [SerializeField]
    private GameObject Sales_layout;
    [SerializeField]
    private GameObject Management_MIDDLE_layout;
    [SerializeField]
    private GameObject Management_layout;

    public bool researcherbuttonclick;
    public bool salesbuttonclick;
    public bool managementbuttonclick;

    public void Development()
    {
        Home_MIDDLE_layout.SetActive(false);
        Researcher_MIDDLE_layout.SetActive(true);
        Researcher_layout.SetActive(true);
        researcherbuttonclick = true;
        salesbuttonclick = false;
        managementbuttonclick = false;
    }
    public void Sales()
    {
        Home_MIDDLE_layout.SetActive(false);
        Sales_MIDDLE_layout.SetActive(true);
        Sales_layout.SetActive(true);
        researcherbuttonclick = false;
        salesbuttonclick = true;
        managementbuttonclick = false;
    }
    public void Management()
    {
        Home_MIDDLE_layout.SetActive(false);
        Management_MIDDLE_layout.SetActive(true);
        Management_layout.SetActive(true);
        researcherbuttonclick = false;
        salesbuttonclick = false;
        managementbuttonclick = true;
    }
}
