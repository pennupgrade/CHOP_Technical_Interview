using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AcceptButtonScript : MonoBehaviour
{
    Player p;
    public GameObject playerNameStorage;
    public InputField input;
    public GameObject errorMsg1;
    public GameObject errorMsg2;
    public GameObject scrollBar;

    public void OnClick() {
        if (input.text == "")
        {
            StartCoroutine("ErrorMessage1");
        }
        else if (scrollBar.GetComponent<Scrollbar>().value >= 0.1333379) {
            StartCoroutine("ErrorMessage2");
        }
        else
        {
            p = playerNameStorage.GetComponent<Player>();
            p.setName(input.text);
            DontDestroyOnLoad(playerNameStorage);
            SceneManager.LoadScene("AcceptanceScene");
        }
    }

    private IEnumerator ErrorMessage1()
    {
        errorMsg1.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        errorMsg1.SetActive(false);
    }

    private IEnumerator ErrorMessage2()
    {
        errorMsg2.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        errorMsg2.SetActive(false);
    }


}
