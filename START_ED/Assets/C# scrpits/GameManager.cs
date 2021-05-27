using System.Collections;
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

    public Text Serpin_text;
    // 개수
    static private int Serpin;
    // 생성량
    static private double Serpin_create = 10;
    // 배수
    static private float Serpin_multiple = 1;
    // 레벨
    static private int Serpin_level = 1;
    // 세르핀 총량
    static private double Serpin_All;
    // 세르핀 현재 값
    static private double serpin_volume;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        Serpin_Level_text.text = "세르핀 레벨 : " + Serpin_level.ToString() + " " + Serpin_create.ToString();
        Serpin_text.text = "Serpin : " + Get_Serpin_ALL().ToString();
    }

    static public double Get_Serpin_ALL() {

        return Serpin_All;
    }

    static public void Serpin_Plus() {
        Serpin++;
        serpin_volume = Serpin_create * Serpin_multiple;
        Serpin_All += serpin_volume;
    }

    private void Serpin_LevelUp() {

        Serpin_create += (Serpin_create * 0.05) + 10;
        Serpin_level++;
    }

}
