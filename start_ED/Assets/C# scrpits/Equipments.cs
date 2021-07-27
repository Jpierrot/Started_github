using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipments : MonoBehaviour
{
    static public double skill_volume = 30;

    private float Serpin_Auto_time;

    private float Serpin_Buff_time;

    /// <summary>
    /// ½ºÅ³1 ½Ã°£Á¦ÇÑ = ÃÊ±â°ª 30ÃÊ
    /// </summary>
    private float time_limit = 30;

    /// <summary>
    /// 01_¼¼¸£ÇÉ ÀÚµ¿È¹µæ
    /// </summary>
    public void Equipment_01Onclick() {
        //¼¼¸£ÇÉ 30 + aÃÊ µ¿¾È ÀÚµ¿È¹µæ ½ÃÀÛ
        StartCoroutine(Start_Serpin_auto());
        Debug.Log("1¹ø ½ºÅ³ »ç¿ë_¼¼¸£ÇÉ");
    }

   public void Equipment_02Onclick() {
        //¼¼¸£ÇÉ È¹µæ·® 3000 + a% Áï½Ã È¹µæ
        Serpin_Manager.Serpin_Plus((Serpin_Manager.Serpin_create) * skill_volume);

        Debug.Log("2¹ø ½ºÅ³ »ç¿ë_¼¼¸£ÇÉ");
        
    }

    public void Equipment_03Onclick() {
        //5ºÐµ¿¾È ¼¼¸£ÇÉ È¹µæ·® 300 + a% Áõ°¡
        StartCoroutine(Start_Serpin_buff());
        Debug.Log("3¹ø ½ºÅ³ »ç¿ë_¼¼¸£ÇÉ");
        
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
        Debug.Log("¼¼¸£ÇÉ ·¹º§ ¹è¼ö" + Serpin_Manager.Serpin_Multiple_level);
        while (Serpin_Buff_time <= 300) {
            Serpin_Buff_time++;
            Debug.Log(Serpin_Buff_time);
            yield return new WaitForSecondsRealtime(1f);
        }
        Serpin_Manager.Serpin_Multiple_level /= 3;
    }
   
}
