using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipments : MonoBehaviour
{

    private float time;

    public void Equipment_01Onclick() {
        StartCoroutine(Start_Serpin_auto());
    }

    public void Equipment_02Onclick() {

    }

    IEnumerator Start_Serpin_auto() {

        while(time < 120) {
            time++;
            Debug.Log(time);
            Serpin_Manager.Serpin_Plus();
            yield return new WaitForSecondsRealtime(0.5f);
        }
        time = 0;

    }
   
}
