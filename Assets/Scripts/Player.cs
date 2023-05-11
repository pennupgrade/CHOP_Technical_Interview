using UnityEngine;

public class Player : MonoBehaviour
{
    private string _playerName;

    // on initialization of scene, we make sure player GameObject is not
    // destroyed when we switch scenes. this is only called once.
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // helper method to get private player name.
    public string GetName()
    {
        return _playerName;
    }

    // helper method to set private player name.
    public void SetName(string newName)
    {
        _playerName = newName;
    }
}
