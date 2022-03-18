using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Version : MonoBehaviour
{
    [SerializeField] Text version;

    //Запускается при запуске скрипта
    void Start()
    {
        version.text = ("Версия Игры: " + Application.version);
        Debug.Log("Application Version : " + Application.version);
    }

}
