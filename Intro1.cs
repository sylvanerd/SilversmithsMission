using UnityEngine;
using System.Collections;

public class Intro1 : MonoBehaviour {

    public bool isAnimated = false;
    public bool isFloating = false;
    public float movespeed = -0.05f;


    public float floatSpeed = 0.0005f;
    private bool goingUp = true;
    public float floatRate = 0.001f;
    private float floatTimer;
   
    

	void Update () 
    {
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);

        if (isAnimated)
        {

            if(isFloating)
            {
                floatTimer += Time.deltaTime * 0.01f;
                Vector3 moveDir = new Vector3(0.0f, floatSpeed, 0.0f);
                transform.Translate(moveDir);

                if (goingUp && floatTimer >= floatRate)
                {
                    goingUp = false;
                    floatTimer = 0;
                    floatSpeed = -floatSpeed;
                }

                else if(!goingUp && floatTimer >= floatRate)
                {
                    goingUp = true;
                    floatTimer = 0;
                    floatSpeed = +floatSpeed;
                }
            }
        }
	}
}
