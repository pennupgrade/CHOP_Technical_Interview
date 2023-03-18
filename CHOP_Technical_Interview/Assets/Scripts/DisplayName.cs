using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public GameObject player;
    public GameObject nameDisplay;

    // Start is called before the first frame update
    void Start() {
        player = GameObject.Find("Player");
        string n = player.GetComponent<Player>().getName();
        nameDisplay.GetComponent<Text>().text = n + ", you have accepted the terms and conditions :)";
    }
}

