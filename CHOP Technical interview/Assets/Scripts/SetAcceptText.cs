using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAcceptText : MonoBehaviour
{
    Player p;
    string playerName;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerName = p.getName();
        gameObject.GetComponent<UnityEngine.UI.Text>().text = playerName+", you have accepted the terms and conditions!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
