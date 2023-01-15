using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMessage : MonoBehaviour
{
    public GameObject winMessage;
    public GameObject loseMessage;
    public AudioSource audio;
    public AudioClip congrats;
    public bool planetDetected = false;


    void Update()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Jupiter");

        if (gameObjects.Length != 0)
        {
            planetDetected = true;
            winMessage.SetActive(true);
            audio.PlayOneShot(congrats, 0.8f);
            loseMessage.GetComponent<TimerScript>().enabled = false;

        }
    }

}
