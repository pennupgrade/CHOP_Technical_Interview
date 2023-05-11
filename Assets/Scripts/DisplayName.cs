using UnityEngine;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TMP_Text content;
    private GameObject _player;

    // we update the text at the start
    private void Start()
    {
        _player = GameObject.Find("Player");
        content.text = _player.GetComponent<Player>().GetName() + ", you have accepted the terms and conditions.";
    }
}
