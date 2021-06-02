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

    /// <summary>
    /// 세르핀 표기 총량
    /// </summary>
    private double Serpin_ALL_TEXT;

    /// <summary>
    ///  세르핀 현재 값
    /// </summary>
    static private double serpin_volume;

    private char serpin_alphabet_for_text = 'A';

    private void Start() {
        Serpin_create_TEXT = Serpin_create;
    }
    bool serpinChecked = false;
    //Update is called once per frame
    void Update() {

        Serpin_Check();
        if (!serpinChecked) StartCoroutine(meow());
        IEnumerator meow() {
            set_Serpin_create();
            yield break;
        }

        /*StartCoroutine(meow());
        IEnumerator meow(){
            yield return StartCoroutine(delay_1());
        }*/
    }

    public void Serpin_Check() {
        //set_Serpin_create();
        serpinChecked = false;
        Serpin_Level_text.text = "세르핀 레벨 : " + Serpin_level.ToString() + " " + Serpin_create_TEXT.ToString() + serpin_alphabet;
        Serpin_text.text = "Serpin : " + Serpin_ALL_TEXT.ToString() + serpin_alphabet_for_text;
    }

    private void set_Serpin_create() {

        Serpin_create_TEXT = Serpin_create; // TEMP로 정정하자 씹 대머리련아

        int i = (int)serpin_alphabet;
        // 알파벳 숫자로 저장

        serpin_alphabet = plus_Alphabet(i);
        // 
    }
    
    private char plus_Alphabet(int alphabet) {

        if (Serpin_create_TEXT % 1000d < 1000d) {

            Serpin_create_TEXT /= 1000d;
            Debug.Log("알파벳 증가");
            serpinChecked = false;
            return plus_Alphabet(alphabet++);
        }
        else
            serpinChecked = true; 
            return (char)alphabet;

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

   




    IEnumerator delay_1() {

        yield return new WaitForSeconds(10f);
    }

}
