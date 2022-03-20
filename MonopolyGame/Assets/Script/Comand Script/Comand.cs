using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Comand : MonoBehaviour
{
    public void Start_Game()
    {
        SceneManager.LoadScene("Game");
        
    }
}
