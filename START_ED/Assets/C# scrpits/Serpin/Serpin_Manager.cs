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

    public Text Serpin_level_purchase;

    // 개수
    static private int Serpin;
    // 세르핀 생성량
    static private double Serpin_create = 10d;

    // 세르핀 생성량 표기시
    private double Serpin_create_TEMP = 0d;
    // 세르핀 값 알파벳으로 치환
    private char serpin_alphabet = 'A';

    private char serpin_alphabet_ALL = 'A';

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

    public double Serpin_create_TEXT;
     
    private void Update() {
        Serpin_Check();
    }

    private void Serpin_Check() {
        set_Serpin_create();
        set_Serpin_create_ALL();
        var alphabet = serpin_alphabet == '-' ? "" : serpin_alphabet.ToString();
        Serpin_Level_text.text = "세르핀 레벨  : " + $"{Serpin_level} \n생산량 : " + string.Format("{0:0.#}", Serpin_create_TEXT) + alphabet;
        Serpin_text.text = $"세르핀 량 : " + string.Format("{0:0.#}", Serpin_ALL_TEXT) + serpin_alphabet_ALL;
    }

    private void set_Serpin_create() {
        serpin_alphabet = '-';
        Serpin_create_TEXT = Serpin_create;

        plus_Alphabet();
    }

    private void set_Serpin_create_ALL() {
        serpin_alphabet_ALL = ' ';
        Serpin_ALL_TEXT = Serpin_All;

        plus_ALL_Alphabet();
    }

    private void plus_Alphabet() {
        if (Serpin_create_TEXT >= 1000d) {
            Serpin_create_TEXT /= 1000d;

            if (serpin_alphabet == '-')
                serpin_alphabet = 'A';
            else {
                var i = (int)serpin_alphabet;
                serpin_alphabet = (char)++i;
            }

            plus_Alphabet();
        }
    }

    private void plus_ALL_Alphabet() {
        if (Serpin_ALL_TEXT >= 1000d) {
            Serpin_ALL_TEXT /= 1000d;

            if (serpin_alphabet_ALL == ' ')
                serpin_alphabet_ALL = 'A';
            else {
                var i = (int)serpin_alphabet_ALL;
                serpin_alphabet_ALL = (char)++i;
            }

            plus_ALL_Alphabet();
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

    static public void purchase(double volume) {
        if (Serpin_All >= volume) {
            Serpin_All -= volume;
            Debug.Log("차감됨");
        }
    }

    private void Serpin_LevelUp() {
        double volume = Serpin_create * 5;
        if (Serpin_All > volume) {
            Serpin_create_TEMP = Serpin_create;
            Serpin_create += (Serpin_create * 0.05) + 10;
            Serpin_level++;
            purchase(volume);
            Debug.Log("구매 완료");
            Serpin_level_purchase.text = (Serpin_create * 5).ToString();
        }
    }

}
