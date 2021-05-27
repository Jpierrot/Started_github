﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
   public void CheckButtonClick_serpin_levelup() {
        Serpin_LevelUp();
    }

    public Text Serpin_Level_text;
    // 개수
    static private int Serpin;
    // 생성량
    private double Serpin_create = 10;
    // 배수
    private float Serpin_multiple = 1;
    // 레벨
    static private int Serpin_level = 1;
    // 세르핀 총량
    static private double Serpin_All;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        Serpin_Check();
        Serpin_Level_text.text = "세르핀 레벨 : " + Serpin_level.ToString() + " " + Serpin_create.ToString();
    }

    static public double Get_Serpin_ALL() {

        return Serpin_All;
    }

    static public void Serpin_Plus() {
       Serpin++;
    }

    private void Serpin_LevelUp() {

        Serpin_create += (Serpin_create * 0.05) + 10;
        Serpin_level++;
    }
    
    private void Serpin_Check() {
        // 세르핀 총량 == 생성량 * 배수 * 세르핀 수
        Serpin_All = Serpin_create * Serpin_multiple * Serpin;
    }

}
