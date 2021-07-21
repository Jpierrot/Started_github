using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer re_a;


    void Start() {

        // ... your other stuff 
        re_a.color = Color.red;
        StartCoroutine(Change_Color());

    }


    IEnumerator Change_Color() {
        while(true) {
            re_a.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            re_a.color = Color.yellow;
            yield return new WaitForSeconds(0.1f);
            re_a.color = Color.green;
            yield return new WaitForSeconds(0.1f);
            re_a.color = Color.blue;
            yield return new WaitForSeconds(0.1f);
        }
    }



}
