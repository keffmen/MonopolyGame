using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Musik : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Game" )
        {
            Destroy(gameObject);
        }
    }
}
