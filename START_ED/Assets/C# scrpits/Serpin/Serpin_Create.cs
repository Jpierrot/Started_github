using System.Collections;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class Serpin_Create : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    [SerializeField]
    private GameObject obj_parent;
    [SerializeField]
    private float Serpin_speed;
    [SerializeField]
    private int Serpin_Count;
    [SerializeField]
    private int Serpin_Delete;

    [Obsolete]
    private void Start() {
        StartCoroutine(waitSerpin());
    }
    // Update is called once per frame
    private void FixedUpdate() {

        DeleteSerpin();
    }

    private void DeleteSerpin() {
        if (obj_parent.transform.childCount != 1)  {
            Destroy(obj_parent.transform.GetChild(1).gameObject, Serpin_Delete);
        }
    }

    /// <summary>
    /// 세르핀의 생성 시간 만큼 대기
    /// </summary>
    /// <returns>생성 시간</returns>
    IEnumerator waitSerpin()
    {
        while (true)
        {

            if (obj_parent.transform.childCount < Serpin_Count + 1)
            {

                float randomX = Random.Range(-2.5f, 2.5f);
                float randomY = Random.Range(0f, 3.5f);

                GameObject my_obj = Instantiate(obj, new Vector2(randomX, randomY), Quaternion.identity);
                my_obj.transform.parent = obj_parent.transform;
            }
            yield return new WaitForSeconds(Serpin_speed);
        }
    }







}
