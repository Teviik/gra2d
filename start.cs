﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public string SceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneName);
    }
}
