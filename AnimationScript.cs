﻿using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour 
{

    public bool isAnimated = false;

    //public bool isRotating = false;
    public bool isFloating = false;
    //public bool isScaling = false;

    //public Vector3 rotationAngle;
    //public float rotationSpeed;

    public float floatSpeed = 0.0005f;
    private bool goingUp = true;
    public float floatRate = 0.001f;
    private float floatTimer;
   
    //public Vector3 startScale;
    //public Vector3 endScale;

    //private bool scalingUp = true;
    //public float scaleSpeed;
    //public float scaleRate;
    //private float scaleTimer;

	
	// Update is called once per frame
	void Update () {

       
        
        if(isAnimated)
        {
            //if(isRotating)
            //{
            //    transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
            //}

            if(isFloating)
            {
                floatTimer += Time.deltaTime * 0.01f;
                Vector3 moveDir = new Vector3(0.0f, 0.0f, floatSpeed);
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

            //if(isScaling)
            //{
            //    scaleTimer += Time.deltaTime;

            //    if (scalingUp)
            //    {
            //        transform.localScale = Vector3.Lerp(transform.localScale, endScale, scaleSpeed * Time.deltaTime);
            //    }
            //    else if (!scalingUp)
            //    {
            //        transform.localScale = Vector3.Lerp(transform.localScale, startScale, scaleSpeed * Time.deltaTime);
            //    }

            //    if(scaleTimer >= scaleRate)
            //    {
            //        if (scalingUp) { scalingUp = false; }
            //        else if (!scalingUp) { scalingUp = true; }
            //        scaleTimer = 0;
            //    }
            //}
        }
	}
}
