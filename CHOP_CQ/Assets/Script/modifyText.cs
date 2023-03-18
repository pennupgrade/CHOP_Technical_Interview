using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class modifyText : MonoBehaviour
{

	public TMP_Text canvasText;

    // Start is called before the first frame update
    void Start()
    {
	Player player = GameObject.FindWithTag("Player").GetComponent<Player>();
	if (canvasText != null) {
	    if (player.GetName().Length > 0) {
        	canvasText.text = player.GetName() + ", you have accepted the terms and conditions.";
    	    }
	    else{
		canvasText.text = "You have accepted the terms and conditions.";
	    }
	}
    }
}
