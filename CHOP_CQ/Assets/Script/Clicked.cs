using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Clicked : MonoBehaviour
{

    public TMP_InputField nameInputField;

    public void LoadScene(int sceneID)
    {
	Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	player.SetName(nameInputField.text);

        SceneManager.LoadScene(sceneID);
    }
}
