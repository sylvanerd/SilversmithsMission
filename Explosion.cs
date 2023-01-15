using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    //public float delayTime = 2f;

    public void EnableExplosion()
    {
        StartCoroutine(DelayAction());

        IEnumerator DelayAction()
        {


            yield return new WaitForSeconds(5f);

            explosion.SetActive(true);
        }
        //explosion.SetActive(true);
    }
}
