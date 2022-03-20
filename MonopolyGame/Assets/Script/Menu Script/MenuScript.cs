using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject panel_Settings;
    [SerializeField] GameObject panel_Exit;
    [SerializeField] AudioSource Musik_Player;
    


    void Start()
    {
        panel_Settings.SetActive(false);
        panel_Exit.SetActive(false);
        DontDestroyOnLoad(Musik_Player);
        

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Comands");
    }

    public void StartSettings()
    {
        panel_Settings.SetActive(true);
    }
    public void BackSettings()
    {
        panel_Settings.SetActive(false);
    }

    public void StartExit()
    {
        panel_Exit.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void ExitNO()
    {
        panel_Exit.SetActive(false);
    }

    public void Sett_Musik()
    {
        Musik_Player.mute = !Musik_Player.mute;
    }

  
}
