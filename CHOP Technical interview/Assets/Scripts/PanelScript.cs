using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            StartCoroutine(Deactivate());
        }
    }

    private IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(5.0f);
        gameObject.SetActive(false);
    }

}
