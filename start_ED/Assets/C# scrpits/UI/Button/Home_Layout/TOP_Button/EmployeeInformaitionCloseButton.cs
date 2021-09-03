using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeInformaitionCloseButton : MonoBehaviour
{
    [SerializeField]
    private GameObject employeeinformaitionpanel;

    public void EmployeeinformaitionpanelClose()
    {
        employeeinformaitionpanel.SetActive(false);
    }

}
