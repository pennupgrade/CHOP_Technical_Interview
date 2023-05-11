using UnityEngine;
using TMPro;

public class DisclosureFileReader : MonoBehaviour
{
    public TMP_Text content;
    public TextAsset file;

    // we read in the disclosure.txt file once at the beginning,
    // and set the text in the scrollview accordingly.
    private void Start()
    {
        content.text = file.ToString();
    }
}
