using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string playerName;

    // on initialization of scene, we make sure player GameObject is not
    // destroyed when we switch scenes. this is only called once.
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // helper method to get private player name.
    public string getName()
    {
        return playerName;
    }

    // helper method to set private player name.
    public void setName(string newName)
    {
        playerName = newName;
    }
}
