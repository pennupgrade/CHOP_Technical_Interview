using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class AcceptButtonController : MonoBehaviour
{
    public TMP_InputField field;
    public GameObject player;
    public Button acceptButton;

    // we set the player name from the input field right before
    // switching to AcceptanceScene
    public void switchScene()
    {
        player.GetComponent<Player>().setName(field.text);
        SceneManager.LoadScene("AcceptanceScene");
    }

    // while the input field is empty, we disable the button.
    void Update()
    {
        if (field.text == "")
        {
            acceptButton.interactable = false;
        }
        else
        {
            acceptButton.interactable = true;
        }
    }
}
