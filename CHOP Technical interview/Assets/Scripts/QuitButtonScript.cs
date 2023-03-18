using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonScript : MonoBehaviour
{

    public GameObject canvas;

    public void OnClick() {
        Application.Quit();
        Debug.Log("Quitted");
    }

    void Start()
    {
        DontDestroyOnLoad(canvas);
    }

}
