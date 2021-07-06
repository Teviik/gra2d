using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menadzerpunktow : MonoBehaviour
{

    public Text odlegloscText;
    public Text rekordText;

    public float odlegloscCount;
    public float rekordCount;

    public float punktyzasekunde;

    public bool odlegloscIncreasing;

    


    void Start()
    {
        if(PlayerPrefs.HasKey("rekord odleglosci"))
        {
            rekordCount = PlayerPrefs.GetFloat("rekord odleglosci");
        }




    }

    
    void Update()
    {
        if (odlegloscIncreasing)
        {
            odlegloscCount += punktyzasekunde * Time.deltaTime;
        }

        if(odlegloscCount > rekordCount)
        {
            rekordCount = odlegloscCount;
            PlayerPrefs.SetFloat("rekord odleglosci", rekordCount);
        }


        odlegloscText.text = Mathf.Round(odlegloscCount) + " m ";
        rekordText.text = Mathf.Round(rekordCount) + " m ";



    }

    

}
