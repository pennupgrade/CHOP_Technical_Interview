using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenText : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textContainer;
    private string txt;

    void Start()
    {
        txt = System.IO.File.ReadAllText(@"disclosure.txt");

        this.GetComponent<TMPro.TMP_Text>().text = txt;
    }
}
