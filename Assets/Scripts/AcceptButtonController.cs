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
    public void SwitchScene()
    {
        player.GetComponent<Player>().SetName(field.text);
        SceneManager.LoadScene("AcceptanceScene");
    }

    // while the input field is empty, we disable the button.
    private void Update()
    {
        acceptButton.interactable = field.text != "";
    }
}
