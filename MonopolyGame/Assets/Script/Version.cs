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

    //����������� ��� ������� �������
    void Start()
    {
        version.text = ("������ ����: " + Application.version);
        Debug.Log("Application Version : " + Application.version);
    }

}
