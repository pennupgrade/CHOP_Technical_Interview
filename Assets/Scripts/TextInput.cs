using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    // Start is called before the first frame update

    private string text;
    public TMPro.TMP_InputField mainInputField;
    public GameObject Player;
    public GameObject input_box;
    public GameObject MainPanel;

    void Start()
    {
        text = null;
        mainInputField.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(proceed);

    }
    public void ValueChangeCheck()
    {
        text = mainInputField.text;
        if(canProceed())
        {
            this.GetComponent<Image>().color = new Color(255, 255, 255, 1f);
        }
        else
        {
            this.GetComponent<Image>().color = new Color(255, 255, 255, 0.5f);
        }
    }
    public bool canProceed()
    {
        return !(text.Equals(null) || text.Length == 0);
    }

    public void proceed()
    {
        if (canProceed())
        {
            Player.GetComponent<DontDestroy>().setName(text);
            input_box.SetActive(false);
            MainPanel.SetActive(true);
        }
    }
}
