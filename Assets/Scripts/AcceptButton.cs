using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AcceptButton : MonoBehaviour
{
    public TMP_InputField field;
    public GameObject player;

    public void updatePlayerName()
    {
        player.GetComponent<Player>().setName(field.text);
    }

    public void switchScene()
    {
        SceneManager.LoadScene("AcceptanceScene");
    }
}
