﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class RetryMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene("Main Scene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
