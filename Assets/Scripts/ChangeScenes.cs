﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void ChangeIntrotoMainMenu()
    {
        SceneChange("Main Menu");
    }
}
