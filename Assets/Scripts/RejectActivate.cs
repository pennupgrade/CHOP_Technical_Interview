using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RejectActivate : MonoBehaviour
{
    public GameObject Accept;
    public GameObject Reject;
    public GameObject rejecitonPanel;

    public void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(proceed);
    }
    public void cont()
    {
        Button acc = Accept.GetComponent<Button>();
        Button rej = Reject.GetComponent<Button>();

        acc.interactable = false;
        rej.interactable = false;

        rejecitonPanel.SetActive(true);
    }

    public void proceed()
    {
        cont();
    }

}
