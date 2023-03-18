using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Image soundOn;
    [SerializeField] Image soundOff;
    private bool muted = false;

    void Start() {
        updateIcon();
    }

    public void onClick() {
        if (!muted) {
            muted = true;
            AudioListener.pause = true;
        } else {
            muted = false;
            AudioListener.pause = false;
        }
        updateIcon();
    }

    private void updateIcon() {
        if (!muted) {
            soundOn.enabled = true;
            soundOff.enabled = false;
        } else {
            soundOff.enabled = true;
            soundOn.enabled = false;
        }
    }
}
