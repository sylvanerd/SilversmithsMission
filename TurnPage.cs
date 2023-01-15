using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPage : MonoBehaviour
{
    public bool isAnimated = false;
    public bool isFloating = false;
   
    public float floatSpeed = 0.001f;
    private bool goingUp = true;
    public float floatRate = 0.002f;
    private float floatTimer;

    void Update()
    {

        if (isAnimated)
        {
            if (isFloating)
            {
                floatTimer += Time.deltaTime * 0.01f;
                Vector3 moveDir = new Vector3(floatSpeed,0.0f, 0.0f);
                transform.Translate(moveDir);

                if (goingUp && floatTimer >= floatRate)
                {
                    goingUp = false;
                    floatTimer = 0;
                    floatSpeed = -floatSpeed;
                }

                else if (!goingUp && floatTimer >= floatRate)
                {
                    goingUp = true;
                    floatTimer = 0;
                    floatSpeed = +floatSpeed;
                }
            }

           
        }
    }
}
