using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forSerpin : MonoBehaviour
{
    float time = 0;
    public float _fadeTime = 5f;
    private float ildan = 0f;
    private bool fade_out_start = false;
    private bool just_one_touch = true;

    private void Start() {
          
    }
    private void Update() {

        ildan += Time.deltaTime;

        if (fade_out_start || ildan > 4.5f) {
            if (time < _fadeTime) {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f - time / _fadeTime);
            }
            else {
                time = 0;
                Destroy(this.gameObject, 0.5f);
                this.gameObject.SetActive(false);
            }
            time += Time.deltaTime;
        }

    }
    private void OnMouseDown() {
        if (just_one_touch)
        {
            Serpin_Manager.Serpin_Touch();
            Destroy(gameObject, 0.5f);
            fade_out_start = true;
            just_one_touch = false;
        }
    }


}
