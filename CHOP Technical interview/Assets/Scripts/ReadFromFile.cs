using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadFromFile : MonoBehaviour
{
    public GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
        string fileText = System.IO.File.ReadAllText(@"disclosure.txt");
        txt.GetComponent<UnityEngine.UI.Text>().text = fileText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
