using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class closeScreen : MonoBehaviour
{
    	public void GoBack (int sceneID) {

        	SceneManager.LoadScene(sceneID);
	}

	public void QuitGame () {

        	Application.Quit();
	}
}
