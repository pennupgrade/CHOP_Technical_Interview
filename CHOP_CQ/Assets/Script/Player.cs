using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private string playerName;
	
	public void SetName(string s){
		playerName = s;
	}
	
	public string GetName(){
		return playerName;
	}
}
