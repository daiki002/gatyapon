﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitelManager : MonoBehaviour
{
    public void ChangeSceen()
    {
        SceneManager.LoadScene("Game");
    }
}
