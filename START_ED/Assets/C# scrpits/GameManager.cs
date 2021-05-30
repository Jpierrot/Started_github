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
    // 세르핀 생성량
    static private double Serpin_create = 10;
    // 세르핀 생성량 표기시
    private double Serpin_create_TEXT;

    // 세르핀 값 알파벳으로 치환
    private char serpin_alphabet = 'A';

    // 배수
    static private float Serpin_multiple = 1;
    // 레벨
    static private int Serpin_level = 1;
    // 세르핀 총량
    static private double Serpin_All;

    // 세르핀 표기 총량
    private double Serpin_ALL_TEXT;
    // 세르핀 현재 값
    static private double serpin_volume;

    

    private char serpin_alphabet_for_text = 'A';

    // Update is called once per frame
    void Update()
    {
        Serpin_Check();
    }

    public void Serpin_Check() {
        Serpin_Alphabet_text();
        Serpin_Alphabet_create();
        Serpin_Level_text.text = "세르핀 레벨 : " + Serpin_level.ToString() + " " + Serpin_create_TEXT.ToString() + serpin_alphabet;
        Serpin_text.text = "Serpin : " + Serpin_ALL_TEXT.ToString() + serpin_alphabet_for_text;
    }

    public void Serpin_Alphabet_create() {
        // 세르핀 생산량 표기 값 = 세르핀 생산량
        Serpin_create_TEXT = Serpin_create;
        
        int i = (int)serpin_alphabet;

        //만약 세르핀 생산량 표기가 1000보다 작아질 시 반복문 탈출
        if (Serpin_create_TEXT > (double)1000) {
            Serpin_create_TEXT /= (double)1000;
            // 알파벳 하나 증가
            i++;
            serpin_alphabet = (char)i;
        }
            
        // 1000보다 클 경우 1000을 나눔
       

        //소숫점 이하 생략
        string str = string.Format(" {0 : 0}", Serpin_create_TEXT);
        Serpin_create_TEXT = double.Parse(str);
    }

    public void Serpin_Alphabet_text() {
        Serpin_ALL_TEXT = Serpin_All;
        int i = (int)serpin_alphabet_for_text;


        while (true) {
            if (Serpin_ALL_TEXT < 1000) {
                break;
            }
            i++;
            serpin_alphabet_for_text = (char)i;
            Serpin_ALL_TEXT /= (double)1000;
        }
        string str = string.Format(" {0 : 0 }", Serpin_ALL_TEXT);
        Serpin_ALL_TEXT = double.Parse(str);
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
