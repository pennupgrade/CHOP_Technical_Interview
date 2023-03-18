using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveName : MonoBehaviour
{
    public TMP_InputField input;
    private GameObject player;

    public void LoadScene() {
        player = GameObject.Find("Player"); //.GetComponent<Player>();
        player.GetComponent<Player>().setName(input.text);
    }
}
