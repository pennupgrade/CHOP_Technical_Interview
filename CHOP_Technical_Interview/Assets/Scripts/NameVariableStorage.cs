using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameVariableStorage : MonoBehaviour
{
    
    public string name;
    public GameObject nameInputField;
    public GameObject nameDisplay;

    public void storeName() {
        name = nameInputField.GetComponent<Text>().text;
        nameDisplay.GetComponent<Text>().text = "YOUR NAME IS: " + name;
    }
}
