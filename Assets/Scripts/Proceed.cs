using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Proceed : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;

    public void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(proceed);
    }
    public void cont()
    {
        // this is where we scene swap
        DontDestroyOnLoad(Player);
        SceneManager.LoadScene("AcceptanceScene");
    }

    public void proceed()
    {
        cont();
    }
}
