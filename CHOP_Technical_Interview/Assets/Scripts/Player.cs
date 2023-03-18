using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private string Name = "";

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    public void setName(string newName) {
        Name = newName;
    }

    public string getName() {
        return Name;
    }
}
