using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 개수
    static private int Serpin;
    // 생성량
    private double Serpin_create = 10;
    // 배수
    private float Serpin_multiple = 1;
    // 레벨
    static private int Serpin_level = 1;
    // 세르핀 총량
    [SerializeField]
    private double Serpin_All;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Serpin_Check();
    }

    
    static public void Serpin_Plus() {
       Serpin++;
    }

    private void Serpin_LevelUp() {

        Serpin_create += (Serpin_create * 0.05) + 10;
        Serpin_level++;
    }
    
    private void Serpin_Check() {
        // 세르핀 총량 == 생성량 * 배수 * 세르핀 수
        Serpin_All = Serpin_create * Serpin_multiple * Serpin;
    }

}
