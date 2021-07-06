using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;


        FindObjectOfType<licznikpunktow>().pizza();

        Destroy(gameObject, 1f);
    }
}
