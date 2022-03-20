using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Script : MonoBehaviour
{
    [SerializeField] GameObject Panel_kubik;
    [SerializeField] GameObject Player;
    [SerializeField] InputField input_i;
     int i;
    int s = 1;
    int k;

    public void Start()
    {
        Panel_kubik.SetActive(true);

    }

    public void Go()
    {
        i = int.Parse(input_i.text);
        Panel_kubik.SetActive(false);
        Player_Start();

    }

     void Player_Start()
     {
        while ( k < i )
        {
         Player.transform.Translate(Vector3.forward * s);
            k++;
        }
        
        
     }

}
