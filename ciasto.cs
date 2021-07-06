using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciasto : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;


        FindObjectOfType<licznikpunktow>().ciasto();

        Destroy(gameObject, 1f);
    }
}
