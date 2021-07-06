using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPrzeszkoda : MonoBehaviour
{
    //public Transform GeneratorPoziomu;
    //private Vector3 platformStartpoint;

    //public player gracz;
    //private Vector3 graczstartpoint;

    // void Start()
    //{
        //platformStartpoint = GeneratorPoziomu.position;
       // graczstartpoint = gracz.transform.position;
    //}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        SceneManager.LoadScene("koniecGry");
    }
}
