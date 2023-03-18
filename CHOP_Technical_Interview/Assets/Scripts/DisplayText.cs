using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public TMP_Text content;
    public TextAsset file;

    void Start() {
        content.text = file.ToString();
    }
}
