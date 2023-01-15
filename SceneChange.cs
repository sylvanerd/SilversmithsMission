using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;


    public void ChangeScene()
    {
        StartCoroutine(DelayAction());
        

        IEnumerator DelayAction()
        {

            //Wait for the specified delay time before continuing.
            yield return new WaitForSeconds(6f);

            scene1.SetActive(false);
            scene2.SetActive(true);
        }
    }
}
