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

    /// <summary>
    /// 세르핀 레벨
    /// </summary>
    public Text Serpin_Level_text;

    /// <summary>
    /// 세르핀 생성량
    /// </summary>
    public Text Serpin_create_text;

    /// <summary>
    /// 세르핀 레벨업 비용
    /// </summary>
    public Text Serpin_level_purchase;
     
    // 획득 개수
    static private int Serpin;

    // 세르핀 생성량
    static private double Serpin_create = 100d;

    // 세르핀 생성량 표기시
    private double Serpin_create_TEMP = 0d;

    // 세르핀 값 알파벳으로 치환
    private char serpin_alphabet = 'A';

    private char serpin_alphabet_ALL = 'A';

    private char serpin_purchase = 'A';



    // 배수
    
    /// <summary>
    /// 레벨당 세르핀 배수
    /// </summary>
    static private float Serpin_multiple_level = 1;
    // 레벨
    static private int Serpin_level = 1;
    // 세르핀 총량
    static private double Serpin_All;

    /// <summary>
    /// 세르핀 표기 총량
    /// </summary>
    private double Serpin_ALL_TEXT;

    private double Serpin_create_TEXT;

    private double Serpin_purchase_Text_double;

    /// <summary>
    ///  세르핀 현재 값
    /// </summary>
    static private double serpin_volume;

    /// <summary>
    /// 세르핀 레벨업 비용
    /// </summary>
    private double volume = 50;

    private void Start() {
        Serpin_level_purchase.text = "50";
    }

    private void Update() {
        Serpin_Check();
    }

    private void Serpin_Check() {
        
        set_Serpin_create();
        set_Serpin_create_ALL();
        var alphabet = serpin_alphabet == '-' ? "" : serpin_alphabet.ToString();
        Serpin_Level_text.text = "세르핀 레벨  : " + $"{Serpin_level} \n생산량 : " + string.Format("{0:0.#}", Serpin_create_TEXT) + alphabet; 
        Serpin_create_text.text = $"세르핀 량 : " + string.Format("{0:0.#}", Serpin_ALL_TEXT) + serpin_alphabet_ALL;
    }

    private void set_Serpin_create() {
        serpin_alphabet = '-';
        Serpin_create_TEXT = serpin_volume;

        plus_Alphabet();
    }

    private void set_Serpin_create_ALL() {
        serpin_alphabet_ALL = ' ';
        Serpin_ALL_TEXT = Serpin_All;

        plus_ALL_Alphabet();
    }

    private void set_Serpin_alphabet(ref char alphabet, ref double num_text, ref double num) {
        alphabet = ' ';
        num_text = num;

        plus_all_Alphabet(ref alphabet, ref  num_text, ref num);
    }

    private void plus_all_Alphabet(ref char alphabet, ref double num_text, ref double num) {
        if (num_text >= 1000d) {
            num_text /= 1000d;

            if (alphabet == ' ')
                alphabet = 'A';
            else {
                var i = (int)alphabet;
                alphabet = (char)++i;
            }

            plus_all_Alphabet(ref alphabet, ref num_text, ref num);
        }
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
        
        serpin_volume = Serpin_create * Serpin_multiple_level;
        Serpin_All += serpin_volume;
    }

    static public void purchase(double volume) {
        if (Serpin_All >= volume) {
            Serpin_All -= volume;
            Debug.Log("차감됨");
        }
        else
            Debug.Log("값이 부족");
    }

    private void Serpin_LevelUp() {
        
        if (Serpin_All >= volume) {
            
            Serpin_create_TEMP = Serpin_create;
            Serpin_create += (Serpin_create * 0.05) + 5;
            Serpin_level++;

            purchase(volume);
            Debug.Log("구매 완료");
            
            
            volume += (volume * 0.3);
            //구매량 재화 단위 맞추기
            set_Serpin_alphabet(ref serpin_purchase, ref Serpin_purchase_Text_double,  ref volume);
            Serpin_level_purchase.text = string.Format("{0:0.#}", Serpin_purchase_Text_double) + serpin_purchase;

            if (Serpin_level % 10 == 0)
            {
                Serpin_multiple_level *= 2f;
            }

        }
        serpin_volume = Serpin_create * Serpin_multiple_level;
    }

    /// <summary>
    /// 세르핀 량과 알파벳을 넣으면 값으로 변환시켜줌;
    /// </summary>
    /// <param name="volume">값</param>
    /// <param name="alphabet">넣을 값(Ex a, b, c)</param>
    /// <returns>원래 값으로 변환된 값을 반환</returns>
    static public double ChangeVolume_ALL(double volume,char alphabet)
    {
        int num=0;
        var i = (int)alphabet;
        
        while (num!=i-64)
        {
            volume *= 1000;
            num++;
        }
        return volume;
    }

}
