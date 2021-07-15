using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re_A : MonoBehaviour
{
    ///특성 = specificity
    public static int specificity_speed = 0;
    public static int specificity_create = 0;
    public static int specificity_epic = 0;

    /// <summary>
    /// 페르센 량
    /// </summary>
    public static double persen_a = Serpin_Manager.ChangeVolume_ALL(2, 'A');

    private int a_level;

    private double persen_a_text;

    private double a_levelup_price = Serpin_Manager.ChangeVolume_ALL(4, 'A');

    private double a_purchase_with;

    //a페르센 단위
    private char a_alphabet;

    //레벨업 a의 단위;
    private char a_level_alphabet;

    [SerializeField]
    Text a_purchase_text;

    [SerializeField]
    Text a_persen_text;

    

    /// <summary>
    /// 연구원A 페르센 채굴 속도
    /// </summary>
    private float persen_speed = 1;

    private void Start() {
        StartCoroutine(Researcher_PersenA());
    }

    // 연구원들 코루틴을 미리 돌려놓음.. 단 해금 전까지 값은 0으로 고정.ㄴ

    private void Update() {
        ResearcherA();
        A_Persen_Setting();
    }

    private void ResearcherA() {
        
        ///특성이 0을 넘으면, 해당하는 효과를 부여하고 특성을 0으로 리셋

        if(specificity_speed > 0) {
            persen_speed -= (persen_speed /= 10);
            specificity_speed--;
        }

        if(specificity_create > 0) {
            persen_a += (persen_a / 10);
            specificity_speed--;
        }

        if (specificity_epic > 0) {
            persen_a += (persen_a / 20);
            persen_speed -= (persen_speed /= 20);
            specificity_epic--;    
        }

    }

    private void A_Persen_Setting()
    {
        Persen_Manager.set_Persen_alphabet(ref a_alphabet, ref persen_a_text, ref persen_a);
        a_persen_text.text = "A 레벨  : " + $"{a_level} \n생산량 : " + string.Format("{0:0.#}", persen_a_text) + a_alphabet;

    }

    [SerializeField]
    public void Persen_LevelUp() {

        //구입할 수 있는 조건이 되면
        if (Persen_Manager.persen_All >= a_levelup_price)
        {
            //페르센을 지불
            Persen_Manager.purchase(a_levelup_price);

            //페르센 생산량을 올려줌
            persen_a_text = persen_a;
            persen_a += (persen_a_text * 0.05) + 5;
            a_level++;

            // 레벨이 10이면 2배 증가
            if (a_level % 10 == 0)
            {
                persen_a *= 2f;
            }

            //
            a_levelup_price += (a_levelup_price * 0.3);

            //구매에 쓰이는 값들 알파벳 정렬
            Persen_Manager.set_Persen_alphabet(ref a_level_alphabet, ref a_purchase_with, ref a_levelup_price);
            a_purchase_text.text = string.Format("{0:0.#}", a_purchase_with) + a_level_alphabet;
        }

    }

    IEnumerator Researcher_PersenA() {
        while (true) {
            Persen_Manager.Persen_Researcher(persen_a);
            yield return new WaitForSeconds(persen_speed);
        }
    }
}
