using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Serpin_Manager : MonoBehaviour
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
    static private double Serpin_create = 10d;

    // 세르핀 생성량 표기시
    private double Serpin_create_TEMP = 0d;
    // 세르핀 값 알파벳으로 치환
    private char serpin_alphabet = 'A';

    // 배수
    static private float Serpin_multiple = 1;
    // 레벨
    static private int Serpin_level = 1;
    // 세르핀 총량
    static private double Serpin_All;

    /// <summary>
    /// 세르핀 표기 총량
    /// </summary>
    private double Serpin_ALL_TEXT;

    /// <summary>
    ///  세르핀 현재 값
    /// </summary>
    static private double serpin_volume;

    private bool serpin_checked = false;

    private int serpin_alphabet_count = 0;

    private char serpin_alphabet_for_text = 'A';

    private void Start() {
        Serpin_create_TEMP = Serpin_create;
    }

    //Update is called once per frame
    private void Update() {

        Serpin_Check();
    }

    public void Serpin_Check() {

        set_Serpin_create();
        Serpin_Level_text.text = "세르핀 레벨 : " + Serpin_level.ToString() + " " + Serpin_create_TEMP.ToString() + serpin_alphabet;
        Serpin_text.text = "Serpin : " + Serpin_ALL_TEXT.ToString() + serpin_alphabet_for_text;
    }

    private void set_Serpin_create() {
        
        // 알파벳 숫자로 저장
        int i = (int)serpin_alphabet;
       
        serpin_alphabet = plus_Alphabet(i);
    }
    
    private char plus_Alphabet(int alphabet) {

        if (Serpin_create_TEMP / 1000d >= 1d) {

            Serpin_create_TEMP /= 1000d;
            serpin_alphabet_count++;
       
            Debug.Log("1000으로 다시 나누기");
            
            if (serpin_checked) {
                alphabet += serpin_alphabet_count;
                serpin_checked = false;
            }
            Debug.Log("알파벳 증가");
            return plus_Alphabet(alphabet);
        }
        else {
            serpin_alphabet_count = 0;
            serpin_checked = true;
            return (char)alphabet;
        }

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
        Serpin_create_TEMP = Serpin_create;
        Serpin_create += (Serpin_create * 0.05) + 10;
        Serpin_level++;
    }

}
