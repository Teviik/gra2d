using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbuz : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;


        FindObjectOfType<licznikpunktow>().arbuz();

        Destroy(gameObject, 1f);
    }
}
