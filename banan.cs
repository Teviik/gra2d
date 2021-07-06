using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banan : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;


        FindObjectOfType<licznikpunktow>().banan();

        Destroy(gameObject, 1f);
    }
}
