using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{

    public GameObject introPrefab;
    



    // Update is called once per frame
    public void Spawn()
    {

        introPrefab.GetComponent<SceneChange>().enabled = true;

    }
}
