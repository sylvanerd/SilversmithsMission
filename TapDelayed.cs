using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapDelayed : MonoBehaviour
{
    public GameObject tapSoaceship;
    public float timeDelayed = 15f;
    public AudioSource audio;

    public void TapSpaceshipDelayed()
    {
        StartCoroutine(DelayAction());

        IEnumerator DelayAction()
        {
            AudioSource audio = GetComponent<AudioSource>();
            yield return new WaitForSeconds(timeDelayed);

            tapSoaceship.SetActive(true);
            audio.Play();
        }  
    }
}
