﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitButton : MonoBehaviour
{ 
    public void QuitButton()
    {
        SceneManager.LoadScene(0);
    }
}
