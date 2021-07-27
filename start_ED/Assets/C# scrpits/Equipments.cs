using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipments : MonoBehaviour
{
    static public double skill_volume = 30;

    private float Serpin_Auto_time;

    private float Serpin_Buff_time;

    /// <summary>
    /// ��ų1 �ð����� = �ʱⰪ 30��
    /// </summary>
    private float time_limit = 30;

    /// <summary>
    /// 01_������ �ڵ�ȹ��
    /// </summary>
    public void Equipment_01Onclick() {
        //������ 30 + a�� ���� �ڵ�ȹ�� ����
        StartCoroutine(Start_Serpin_auto());
        Debug.Log("1�� ��ų ���_������");
    }

   public void Equipment_02Onclick() {
        //������ ȹ�淮 3000 + a% ��� ȹ��
        Serpin_Manager.Serpin_Plus((Serpin_Manager.Serpin_create) * skill_volume);

        Debug.Log("2�� ��ų ���_������");
        
    }

    public void Equipment_03Onclick() {
        //5�е��� ������ ȹ�淮 300 + a% ����
        StartCoroutine(Start_Serpin_buff());
        Debug.Log("3�� ��ų ���_������");
        
    }



    IEnumerator Start_Serpin_auto() {

        while(Serpin_Auto_time < time_limit * 2) {
            Serpin_Auto_time++;
            Debug.Log(Serpin_Auto_time);
            Serpin_Manager.Serpin_Touch();
            yield return new WaitForSecondsRealtime(0.5f);
        }
        Serpin_Auto_time = 0;

    }

    IEnumerator Start_Serpin_buff() {

        Serpin_Manager.Serpin_Multiple_level *= 3;
        Debug.Log("������ ���� ���" + Serpin_Manager.Serpin_Multiple_level);
        while (Serpin_Buff_time <= 300) {
            Serpin_Buff_time++;
            Debug.Log(Serpin_Buff_time);
            yield return new WaitForSecondsRealtime(1f);
        }
        Serpin_Manager.Serpin_Multiple_level /= 3;
    }
   
}
