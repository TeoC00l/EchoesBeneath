using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressTabScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.SetActive(false);
        Invoke("EnableView", 13f);
    }

    private void EnableView()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            gameObject.SetActive(false);
        }
    }
}
