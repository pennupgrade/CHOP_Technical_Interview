using UnityEngine;
using UnityEngine.UIElements;
using System.IO;
using TMPro;

public class addText : MonoBehaviour
{
    public TMP_Text text;

    public TextAsset file;

    private void Start()
    {
        // Read the file's text
       text.text = file.ToString();
    }
}