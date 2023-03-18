using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("DontDestroyOnLoad");
        string txt = "Joe";
        if (!obj.Equals(null))
        {
            txt = obj.GetComponent<DontDestroy>().getName();
            this.GetComponent<TMPro.TMP_Text>().text = "good work " + txt + ", you're did it";
        }

    }
}
