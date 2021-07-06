using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[System.Serializable]


public class medal
{
    public Sprite Image;
    public int MinimumPoints;
}

public class GameOverpunkty : MonoBehaviour
{
    public Text Score;
    public Image Medal;
    public GameObject Record;
    

    public medal[] medals;


    
   
    void Start()
    {
        RefreshPoints();
        RefreshMedal();
        RefreshRecord();
       


    }



     int GetCurrentPoints()
    {
        return PlayerPrefs.GetInt("zdobyte punkty", 0);

    }
     void RefreshPoints()
    {
        var punkty = GetCurrentPoints();
        Score.text = punkty +  "pkt!";
        

    }


    void RefreshMedal()
    {
        var punkty = GetCurrentPoints();

        Medal.sprite = medals
            .Where(medal => medal.MinimumPoints <= punkty)
            .OrderBy(medal => medal.MinimumPoints)
            .Last()
            .Image;
    }

    void RefreshRecord()
    {
        var currentPunkty = GetCurrentPoints();
        var recordpunkty = PlayerPrefs.GetInt("rekord punktów", 0);

        bool isRecord = (currentPunkty > recordpunkty);

        if (isRecord)
            PlayerPrefs.SetInt("rekord punktów", currentPunkty);

        Record.SetActive(isRecord);
        Debug.Log(currentPunkty + " / " + recordpunkty);
    }

    


}
