using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpaceship : MonoBehaviour
{
    public float movespeed = -0.1f;


    void Update()
    {
        transform.Translate(Vector3.right * movespeed * Time.deltaTime);
    }
}
