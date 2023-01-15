using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnText : MonoBehaviour
{
    public GameObject convo;
    public float timeDelayed = 4f;
    public AudioSource audio;
    public AudioClip message;
    public bool hasPlayed = false;


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Portal")
        {
            textSpawn();
        }
    }

    public void textSpawn()
    {


        StartCoroutine(DelayAction());

        IEnumerator DelayAction()
        {
            AudioSource audio = GetComponent<AudioSource>();

            yield return new WaitForSeconds(timeDelayed);

            convo.SetActive(true);

            if (!hasPlayed)
            {
                audio.PlayOneShot(message, 0.8f);
                hasPlayed = true;
           
            }
            
        }

    }
}
