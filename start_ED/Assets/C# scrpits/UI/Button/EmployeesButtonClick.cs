using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployeesButtonClick : MonoBehaviour
{

    [SerializeField]
    private Text[] Trait_Text=new Text[3];
    [SerializeField]
    private Image Profile;

    [SerializeField]
    private GameObject employeeinformaitionpanel;


    public void ResearcherButtonOnClick_0()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ResearcherManager researcherManager = GameObject.Find("EmployeeManager").GetComponent<ResearcherManager>();
        Trait_Text[0].text = researcherManager.Trait_Text1[0];
        Trait_Text[1].text = researcherManager.Trait_Text2[0];
        Trait_Text[2].text = researcherManager.Trait_Text3[0];
        Profile.sprite = redEmployButton.researcherimage[0].sprite;
    }
    public void ResearcherButtonOnClick_1()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ResearcherManager researcherManager = GameObject.Find("EmployeeManager").GetComponent<ResearcherManager>();
        Trait_Text[0].text = researcherManager.Trait_Text1[1];
        Trait_Text[1].text = researcherManager.Trait_Text2[1];
        Trait_Text[2].text = researcherManager.Trait_Text3[1];
        Profile.sprite = redEmployButton.researcherimage[1].sprite;
    }
    public void ResearcherButtonOnClick_2()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ResearcherManager researcherManager = GameObject.Find("EmployeeManager").GetComponent<ResearcherManager>();
        Trait_Text[0].text = researcherManager.Trait_Text1[2];
        Trait_Text[1].text = researcherManager.Trait_Text2[2];
        Trait_Text[2].text = researcherManager.Trait_Text3[2];
        Profile.sprite = redEmployButton.researcherimage[2].sprite;
    }
    public void ResearcherButtonOnClick_3()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ResearcherManager researcherManager = GameObject.Find("EmployeeManager").GetComponent<ResearcherManager>();
        Trait_Text[0].text = researcherManager.Trait_Text1[3];
        Trait_Text[1].text = researcherManager.Trait_Text2[3];
        Trait_Text[2].text = researcherManager.Trait_Text3[3];
        Profile.sprite = redEmployButton.researcherimage[3].sprite;
    }
    public void ResearcherButtonOnClick_4()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ResearcherManager researcherManager = GameObject.Find("EmployeeManager").GetComponent<ResearcherManager>();
        Trait_Text[0].text = researcherManager.Trait_Text1[4];
        Trait_Text[1].text = researcherManager.Trait_Text2[4];
        Trait_Text[2].text = researcherManager.Trait_Text3[4];
        Profile.sprite = redEmployButton.researcherimage[4].sprite;
    }
    public void SalesButtonOnClick_0()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        Trait_Text[0].text = salesManager.Trait_Text1[0];
        Trait_Text[1].text = salesManager.Trait_Text2[0];
        Trait_Text[2].text = salesManager.Trait_Text3[0];
        Profile.sprite = redEmployButton.salesimage[0].sprite;
    }
    public void SalesButtonOnClick_1()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        Trait_Text[0].text = salesManager.Trait_Text1[1];
        Trait_Text[1].text = salesManager.Trait_Text2[1];
        Trait_Text[2].text = salesManager.Trait_Text3[1];
        Profile.sprite = redEmployButton.salesimage[1].sprite;
    }
    public void SalesButtonOnClick_2()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        Trait_Text[0].text = salesManager.Trait_Text1[2];
        Trait_Text[1].text = salesManager.Trait_Text2[2];
        Trait_Text[2].text = salesManager.Trait_Text3[2];
        Profile.sprite = redEmployButton.salesimage[2].sprite;
    }
    public void SalesButtonOnClick_3()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        Trait_Text[0].text = salesManager.Trait_Text1[3];
        Trait_Text[1].text = salesManager.Trait_Text2[3];
        Trait_Text[2].text = salesManager.Trait_Text3[3];
        Profile.sprite = redEmployButton.salesimage[3].sprite;
    }
    public void SalesButtonOnClick_4()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        Trait_Text[0].text = salesManager.Trait_Text1[4];
        Trait_Text[1].text = salesManager.Trait_Text2[4];
        Trait_Text[2].text = salesManager.Trait_Text3[4];
        Profile.sprite = redEmployButton.salesimage[4].sprite;
    }
    public void SalesButtonOnClick_5()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        Trait_Text[0].text = salesManager.Trait_Text1[5];
        Trait_Text[1].text = salesManager.Trait_Text2[5];
        Trait_Text[2].text = salesManager.Trait_Text3[5];
        Profile.sprite = redEmployButton.salesimage[5].sprite;
    }
    public void SalesButtonOnClick_6()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        Trait_Text[0].text = salesManager.Trait_Text1[6];
        Trait_Text[1].text = salesManager.Trait_Text2[6];
        Trait_Text[2].text = salesManager.Trait_Text3[6];
        Profile.sprite = redEmployButton.salesimage[6].sprite;
    }
    public void ManagementButtonOnClick_0()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();
        Trait_Text[0].text = managementManager.Trait_Text1[0];
        Trait_Text[1].text = managementManager.Trait_Text2[0];
        Trait_Text[2].text = managementManager.Trait_Text3[0];
        Profile.sprite = redEmployButton.managementimage[0].sprite;
    }
    public void ManagementButtonOnClick_1()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();
        Trait_Text[0].text = managementManager.Trait_Text1[1];
        Trait_Text[1].text = managementManager.Trait_Text2[1];
        Trait_Text[2].text = managementManager.Trait_Text3[1];
        Profile.sprite = redEmployButton.managementimage[1].sprite;
    }
    public void ManagementButtonOnClick_2()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();
        Trait_Text[0].text = managementManager.Trait_Text1[2];
        Trait_Text[1].text = managementManager.Trait_Text2[2];
        Trait_Text[2].text = managementManager.Trait_Text3[2];
        Profile.sprite = redEmployButton.managementimage[2].sprite;
    }
    public void ManagementButtonOnClick_3()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();
        Trait_Text[0].text = managementManager.Trait_Text1[3];
        Trait_Text[1].text = managementManager.Trait_Text2[3];
        Trait_Text[2].text = managementManager.Trait_Text3[3];
        Profile.sprite = redEmployButton.managementimage[3].sprite;
    }
    public void ManagementButtonOnClick_4()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();
        EmployeeButtons employButton = GameObject.Find("Canvas").GetComponent<EmployeeButtons>();
        Trait_Text[0].text = managementManager.Trait_Text1[4];
        Trait_Text[1].text = managementManager.Trait_Text2[4];
        Trait_Text[2].text = managementManager.Trait_Text3[4];
        Profile.sprite = redEmployButton.managementimage[4].sprite;
    }
    public void ManagementButtonOnClick_5()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();
        Trait_Text[0].text = managementManager.Trait_Text1[5];
        Trait_Text[1].text = managementManager.Trait_Text2[5];
        Trait_Text[2].text = managementManager.Trait_Text3[5];
        Profile.sprite = redEmployButton.managementimage[5].sprite;
    }
    public void ManagementButtonOnClick_6()
    {
        employeeinformaitionpanel.SetActive(true);
        RedEmployButton redEmployButton = GameObject.Find("Canvas").GetComponent<RedEmployButton>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();
        Trait_Text[0].text = managementManager.Trait_Text1[6];
        Trait_Text[1].text = managementManager.Trait_Text2[6];
        Trait_Text[2].text = managementManager.Trait_Text3[6];
        Profile.sprite = redEmployButton.managementimage[6].sprite;
    }

}
