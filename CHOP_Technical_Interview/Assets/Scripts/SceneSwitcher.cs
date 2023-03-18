using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private GameObject player;
    private GameObject bgm;
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
        player = GameObject.Find("Player"); 
        bgm = GameObject.Find("BGM"); 
        Destroy(player);
        Destroy(bgm);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
