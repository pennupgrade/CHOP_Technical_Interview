using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer bgm;

    void Awake() {
        if (bgm == null) {
            bgm = this;
            DontDestroyOnLoad(bgm);
        } else {
            Destroy(bgm);
        }
    }
}
