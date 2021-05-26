using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Serpin_Text : MonoBehaviour
{
    [SerializeField]
    private Text Serpin_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Serpin_text.text = "Serpin : " +  GameManager.Get_Serpin_ALL().ToString();
    }
}
