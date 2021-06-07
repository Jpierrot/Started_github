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
    public double Serpin_create_TEXT;

    private void Update() {
        Serpin_Check();
    }

    private void Serpin_Check() {
        set_Serpin_create();
        var alphabet = serpin_alphabet == '-' ? "" : serpin_alphabet.ToString();
        Debug.Log($"{Serpin_create_TEXT} {alphabet}");
    }

    private void set_Serpin_create() {
        serpin_alphabet = '-';
        Serpin_create_TEXT = Serpin_create;

        plus_Alphabet();
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
