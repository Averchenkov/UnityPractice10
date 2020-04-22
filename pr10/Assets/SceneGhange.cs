using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGhange : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Scene1");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("Scene2");
        }
    }
}
