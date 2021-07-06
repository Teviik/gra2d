using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zmianasceny : MonoBehaviour
{
    public string SceneName;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneName);
    }
}
