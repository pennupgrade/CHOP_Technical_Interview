using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class RejectionContinue : MonoBehaviour
{
    // Start is called before the first frame update
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

        acc.interactable = true;
        rej.interactable = true;

        rejecitonPanel.SetActive(false);
    }

    public void proceed()
    {
        cont();
    }
}
