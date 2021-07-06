using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class licznikpunktow : MonoBehaviour
{

    int punkty = 0;
    void Start()
    {
        Savepunkty();
        RefreshText();

    }

    public void jablko()
    {
        punkty+=2;

        Savepunkty();
        RefreshText();
    }

    public void banan()
    {
        punkty += 4;

        Savepunkty();
        RefreshText();
    }

    public void arbuz()
    {
        punkty += 1;

        Savepunkty();
        RefreshText();
    }

    public void burger()
    {
        punkty -= 5;

        Savepunkty();
        RefreshText();
    }

    public void ciasto()
    {
        punkty -= 4;

        Savepunkty();
        RefreshText();
    }

    public void cola()
    {
        punkty -= 6;

        Savepunkty();
        RefreshText();
    }

    public void frytki()
    {
        punkty -= 1;

        Savepunkty();
        RefreshText();
    }

    public void hotdog()
    {
        punkty -= 2;

        Savepunkty();
        RefreshText();
    }

    public void kurczak()
    {
        punkty += 3;

        Savepunkty();
        RefreshText();
    }

    public void marchewka()
    {
        punkty += 6;

        Savepunkty();
        RefreshText();
    }

    public void ryba()
    {
        punkty += 5;

        Savepunkty();
        RefreshText();
    }

    public void pizza()
    {
        punkty -= 3;

        Savepunkty();
        RefreshText();
    }

    void Savepunkty()
    {
        PlayerPrefs.SetInt("zdobyte punkty", punkty);
    }

    void RefreshText()
    {
        GetComponent<Text>().text = punkty + "pkt";
    }
}
