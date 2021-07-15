using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Persen_Manager : MonoBehaviour
   { 

    [SerializeField]
    public void CheckButtonClick_persen_levelup() {
        Persen_LevelUp();
    }

    /// <summary>
    /// 페르센 레벨업 비용
    /// </summary>
    public Text Persen_purchase_text;

    /// <summary>
    /// 페르센 레벨
    /// </summary>
    public Text Persen_Level_text;

    /// <summary>
    /// 페르센 총 값
    /// </summary>
    public Text Persen_text;

    /// <summary>
    /// 페르센 생성 속도
    /// </summary>
    [SerializeField]
    private int persen_speed;

    /// <summary>
    /// 페르센 생성량
    /// </summary>
    static private double persen_create = 100d;

    private char persen_alphabet = 'A';

    private char persen_all_alphabet = 'A';

    /// <summary>
    /// 페르센 배수
    /// </summary>
    static public float persen_multiple_level = 1;

    /// <summary>
    /// 페르센 레벨
    /// </summary>
    static private int persen_level = 1;

    /// <summary>
    /// 페르센 총량
    /// </summary>
    static public double persen_All = 0;

    /// <summary>
    /// 페르센 개당 가격
    /// </summary>
    static private double persen_volume = 0;

    /// <summary>
    /// 세르핀 표기 총량
    /// </summary>
    private double persen_ALL_TEXT;

    /// <summary>
    /// 페르센 표기 생산량
    /// </summary>
    private double persen_create_TEXT;

    /// <summary>
    /// 페르센 레벨업 비용
    /// </summary>
    private double persen_levelup_price = 100d;

    /// <summary>
    /// 페르센 구매 비용
    /// </summary>
    private double persen_purchase;

    /// <summary>
    /// 페르센 구매 비용 표기용
    /// </summary>
    private double persen_purchase_text_with;

    /// <summary>
    /// 페르센 구매 단위
    /// </summary>
    private char persen_purchase_alphabet = 'A';






    // Start is  called before the first frame update
    void Start()
    {
        StartCoroutine(Create_Persen());
    }

    // Update is called once per frame
    void Update()
    {
        Set_C_Persen_text();

    }

    private void Set_C_Persen_text() {
        set_Persen_alphabet(ref persen_alphabet, ref persen_create_TEXT, ref persen_volume);
        set_Persen_alphabet(ref persen_all_alphabet, ref persen_ALL_TEXT, ref persen_All);
        
        var alphabet = persen_alphabet == '-' ? "" : persen_alphabet.ToString();

        Persen_Level_text.text = "페르센 레벨  : " + $"{persen_level} \n생산량 : " + string.Format("{0:0.#}", persen_create_TEXT) + alphabet;
        Persen_text.text = $"페르센 량 : " + string.Format("{0:0.#}", persen_ALL_TEXT) + persen_all_alphabet;
    }

    static public void set_Persen_alphabet(ref char alphabet, ref double num_text, ref double num)
    {
        alphabet = ' ';
        num_text = num;

        plus_all_Alphabet(ref alphabet, ref num_text, ref num);
    }

    static public void plus_all_Alphabet(ref char alphabet, ref double num_text, ref double num)
    {
        if (num_text >= 1000d)
        {
            num_text /= 1000d;

            if (alphabet == ' ')
                alphabet = 'A';
            else
            {
                var i = (int)alphabet;
                alphabet = (char)++i;
            }



            plus_all_Alphabet(ref alphabet, ref num_text, ref num);
        }
    }

    private void Persen_LevelUp()
    {

        //구입할 수 있는 조건이 되면
        if (persen_All >= persen_levelup_price)
        {
            //페르센을 지불
            purchase(persen_levelup_price);

            //페르센 생산량을 올려줌
            persen_create_TEXT = persen_create;
            persen_create += (persen_create_TEXT * 0.05) + 5;
            persen_level++;

            // 레벨이 10이면 2배 증가
            if (persen_level % 10 == 0)
            {
                persen_multiple_level *= 2f;
            }

            //
            persen_levelup_price += (persen_levelup_price * 0.3);

            //구매에 쓰이는 값들 알파벳 정렬
            set_Persen_alphabet(ref persen_purchase_alphabet, ref persen_purchase_text_with, ref persen_levelup_price);
            Persen_purchase_text.text = string.Format("{0:0.#}", persen_purchase_text_with) + persen_purchase_alphabet;

        }

        persen_volume = persen_create * persen_multiple_level;
    }

    static public void purchase(double volume) {
        if (persen_All >= volume) {
            persen_All -= volume;
            Debug.Log("차감됨");
        }
        else
            Debug.Log("값이 부족함");
    }

    /// <summary>
    /// 페르센 추가되는 양을 정의
    /// </summary>
    static public void Persen_Plus()
    {
       persen_volume = persen_create * persen_multiple_level;
       persen_All += persen_volume;
       
    }

    /// <summary>
    /// 연구원들 페르센 값 넣으면 페르센 전체 값에 넣어줌
    /// </summary>
    /// <param name="persen_all"></param>
    static public void Persen_Researcher(double persen_all)
    {
        persen_All += persen_all;

    }

    /// <summary>
    /// 초마다 페르센을 받아옴
    /// </summary>
    /// <returns></returns>
    IEnumerator Create_Persen()
    {
        while (true)
        {
            Persen_Plus();
            yield return new WaitForSeconds(persen_speed);
        }
        
    }

}
