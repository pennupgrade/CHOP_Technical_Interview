using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TMP_Text content;
    private GameObject player;

    // we update the text at the start
    void Start()
    {
        player = GameObject.Find("Player");
        content.text = player.GetComponent<Player>().getName() + ", you have accepted the terms and conditions.";
    }
}
