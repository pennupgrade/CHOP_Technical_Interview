using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public string player_name;

    // Start is called before the first frame update
    void Start()
    {
        player_name = null;
    }

    public string getName()
    {
        return player_name;
    }

    public void setName(string name)
    {
        player_name = name;

    }

}
