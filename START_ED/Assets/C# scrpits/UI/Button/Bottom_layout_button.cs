using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottom_layout_button : MonoBehaviour
{
    /// <summary>
    /// 세르핀 활성화 / 비활성화 할때 필요
    /// </summary>
    [SerializeField] GameObject serpin_Manager;


    [SerializeField]
    private GameObject TOP_layout;
    [SerializeField]
    private GameObject Home_MIDDLE_layout; //기본 창
    [SerializeField]
    private GameObject Shop_MIDDLE_layout; //상점 창
    [SerializeField]
    private GameObject Equipment_MIDDLE_layout; //장비창
    [SerializeField]
    private GameObject Researcher_MIDDLE_layout; // 개발 창
    [SerializeField]
    private GameObject Sales_MIDDLE_layout;//영업 창
    [SerializeField]
    private GameObject Management_MIDDLE_layout;//경영 창
    [SerializeField]
    private GameObject Outing_TOP_layout;// 외출 창

    public void EquipmentButtonOnClick()
    {
        TOP_layout.SetActive(true);
        if (Home_MIDDLE_layout.activeSelf==true)
        {
            Home_MIDDLE_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
        else if (Shop_MIDDLE_layout.activeSelf == true)
        {
            Shop_MIDDLE_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
        else if (Researcher_MIDDLE_layout.activeSelf == true)
        {
            Researcher_MIDDLE_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
        else if (Sales_MIDDLE_layout.activeSelf == true)
        {
            Sales_MIDDLE_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
        else if (Management_MIDDLE_layout.activeSelf == true)
        {
            Management_MIDDLE_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
        else if (Outing_TOP_layout.activeSelf == true)
        {
            serpin_Manager.SetActive(false);
            Outing_TOP_layout.SetActive(false);
            Equipment_MIDDLE_layout.SetActive(true);
        }
    }
    public void ShopButtonOnClick()
    {
        TOP_layout.SetActive(true);
        if (Home_MIDDLE_layout.activeSelf == true)
        {
            Home_MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
        else if (Equipment_MIDDLE_layout.activeSelf == true)
        {
            Equipment_MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
        else if (Researcher_MIDDLE_layout.activeSelf == true)
        {
            Researcher_MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
        else if (Sales_MIDDLE_layout.activeSelf == true)
        {
            Sales_MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
        else if (Management_MIDDLE_layout.activeSelf == true)
        {
            Management_MIDDLE_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
        else if (Outing_TOP_layout.activeSelf == true)
        {
            Outing_TOP_layout.SetActive(false);
            Shop_MIDDLE_layout.SetActive(true);
        }
    }
    public void HomeButtonOnClick()
    {
        TOP_layout.SetActive(true);
        if (Shop_MIDDLE_layout.activeSelf == true)
        {
            Shop_MIDDLE_layout.SetActive(false);
            Home_MIDDLE_layout.SetActive(true);
        }
        else if (Equipment_MIDDLE_layout.activeSelf == true)
        {
            Equipment_MIDDLE_layout.SetActive(false);
            Home_MIDDLE_layout.SetActive(true);
        }
        else if (Researcher_MIDDLE_layout.activeSelf == true)
        {
            Researcher_MIDDLE_layout.SetActive(false);
            Home_MIDDLE_layout.SetActive(true);
        }
        else if (Sales_MIDDLE_layout.activeSelf == true)
        {
            Sales_MIDDLE_layout.SetActive(false);
            Home_MIDDLE_layout.SetActive(true);
        }
        else if (Management_MIDDLE_layout.activeSelf == true)
        {
            Management_MIDDLE_layout.SetActive(false);
            Home_MIDDLE_layout.SetActive(true);
        }
        else if (Outing_TOP_layout.activeSelf == true)
        {
            Outing_TOP_layout.SetActive(false);
            Home_MIDDLE_layout.SetActive(true);
        }
    }
    public void OutingButtonOnClick()
    {
        TOP_layout.SetActive(false);
        if (Equipment_MIDDLE_layout.activeSelf == true)
        {
            Equipment_MIDDLE_layout.SetActive(false);
            Outing_TOP_layout.SetActive(true);
        }
        else if (Shop_MIDDLE_layout.activeSelf == true)
        {
            Shop_MIDDLE_layout.SetActive(false);
            Outing_TOP_layout.SetActive(true);
        }
        else if (Researcher_MIDDLE_layout.activeSelf == true)
        {
            Researcher_MIDDLE_layout.SetActive(false);
            Outing_TOP_layout.SetActive(true);
        }
        else if (Sales_MIDDLE_layout.activeSelf == true)
        {
            Sales_MIDDLE_layout.SetActive(false);
            Outing_TOP_layout.SetActive(true);
        }
        else if (Management_MIDDLE_layout.activeSelf == true)
        {
            Management_MIDDLE_layout.SetActive(false);
            Outing_TOP_layout.SetActive(true);
        }
        else if (Home_MIDDLE_layout.activeSelf == true)
        {
            Home_MIDDLE_layout.SetActive(false);
            Outing_TOP_layout.SetActive(true);
        }

    }
}
