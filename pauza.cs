using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauza : MonoBehaviour
{

    [SerializeField] private Image pauzatekstgoobraz;
    [SerializeField] private GameObject pauzatekstgo;

    [SerializeField] private Sprite pausabuttontekstgo;
    [SerializeField] private Sprite playbuttontekstgo; 

    private bool isGamePaused;

    public void TogglePause()
    {
        isGamePaused = !isGamePaused;

        if(isGamePaused)
        {
            pauzatekstgo.SetActive(true);
            pauzatekstgoobraz.sprite = playbuttontekstgo;

            Time.timeScale = 0;
        }
        else
        {
            pauzatekstgo.SetActive(false);
            pauzatekstgoobraz.sprite = pausabuttontekstgo;
            Time.timeScale = 1;
        }
    }
}
