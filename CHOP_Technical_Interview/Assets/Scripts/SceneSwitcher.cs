using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private GameObject player;
    public GameObject panel1;
    public GameObject panel2;

    public void accept() {
        player = GameObject.Find("Player"); 
        string n = player.GetComponent<Player>().getName();
        
        if (n == "") {
            panel1.SetActive(true);
            panel2.SetActive(true);
        } else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void back() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
