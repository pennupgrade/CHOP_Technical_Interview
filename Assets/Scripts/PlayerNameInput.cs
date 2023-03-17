using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerNameInput : MonoBehaviour
{
    public TMP_InputField field;
    public GameObject player;

    public void updatePlayerName()
    {
        player.GetComponent<Player>().setName(field.text);
    }
}
