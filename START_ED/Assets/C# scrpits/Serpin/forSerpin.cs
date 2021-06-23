using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forSerpin : MonoBehaviour
{
    private void OnMouseDown() {

        Serpin_Manager.Serpin_Plus();
        Destroy(this.gameObject);
    }
}
