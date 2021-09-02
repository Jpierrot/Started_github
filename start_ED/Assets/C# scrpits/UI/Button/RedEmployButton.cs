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
    private GameObject Home_MIDDLE_Layout;
    [SerializeField]
    private GameObject TOP_Layout;

    [SerializeField]
    private GameObject Researcher_MIDDLE_layout;
    [SerializeField]
    private GameObject Sales_MIDDLE_layout;
    [SerializeField]
    private GameObject Management_MIDDLE_layout;


    public Image[] researcherimage;

    public Image[] salesimage;

    public Image[] managementimage;

    [SerializeField]
    private GameObject serpins;

    public int researcherbuttonClickCount = 0;
    public int salesbuttonClickCount = 0;
    public int managementbuttonClickCount = 0;

    public bool redbuttonclick=false;
    // Start is called before the first frame update
    
    public void RedEmployButtonOnClick()
    {
        interview_TOP_Layout.SetActive(false);
        interview_MiDDLE_Layout.SetActive(false);
        TOP_Layout.SetActive(true);
        Home_MIDDLE_Layout.SetActive(true);
        serpins.transform.gameObject.SetActive(true);

        Researcher_MIDDLE_layout.SetActive(false);
        Sales_MIDDLE_layout.SetActive(false);
        Management_MIDDLE_layout.SetActive(false);

        Serpin_Create.serpin_check = true;
        DocumentButton documentButton = GameObject.Find("Canvas").GetComponent<DocumentButton>();
        EmployeeButtons employButton = GameObject.Find("Canvas").GetComponent<EmployeeButtons>();
        ResearcherManager researcherInformation = GameObject.Find("EmployeeManager").GetComponent<ResearcherManager>();
        SalesManager salesManager = GameObject.Find("EmployeeManager").GetComponent<SalesManager>();
        ManagementManager managementManager = GameObject.Find("EmployeeManager").GetComponent<ManagementManager>();

        if (employButton.researcherbuttonclick)
        {
            if (researcherbuttonClickCount < 5)
            {
                researcherimage[researcherbuttonClickCount].sprite = documentButton.profile.sprite;
                researcherbuttonClickCount++;
                researcherInformation.Trait_Text1.Add(Researcher_Trait.Trait_Text[0]);
                researcherInformation.Trait_Text2.Add(Researcher_Trait.Trait_Text[1]);
                researcherInformation.Trait_Text3.Add(Researcher_Trait.Trait_Text[2]);

            }
        }
        else if (employButton.salesbuttonclick)
        {
            if (salesbuttonClickCount < 7)
            {
                salesimage[salesbuttonClickCount].sprite = documentButton.profile.sprite;
                salesbuttonClickCount++;
                salesManager.Trait_Text1.Add(Researcher_Trait.Trait_Text[0]);
                salesManager.Trait_Text2.Add(Researcher_Trait.Trait_Text[1]);
                salesManager.Trait_Text3.Add(Researcher_Trait.Trait_Text[2]);
            }
        }
        else if (employButton.managementbuttonclick)
        {
            if (managementbuttonClickCount < 7)
            {
                managementimage[managementbuttonClickCount].sprite = documentButton.profile.sprite;
                managementbuttonClickCount++;
                managementManager.Trait_Text1.Add(Researcher_Trait.Trait_Text[0]);
                managementManager.Trait_Text2.Add(Researcher_Trait.Trait_Text[1]);
                managementManager.Trait_Text3.Add(Researcher_Trait.Trait_Text[2]);
            }
        }
        redbuttonclick = false;
    }
}
