using UnityEngine;
using System.Collections;

public class Spaceship : MonoBehaviour {

    public bool isAnimated = false;
    public bool isFloating = false;
    public float movespeed = 0.05f;
    //public GameObject partS;
    //public float delayTime = 5f;

    public float floatSpeed = 0.0005f;
    private bool goingUp = true;
    public float floatRate = 0.001f;
    private float floatTimer;
   
    

	void Update () 
    {

        transform.Translate(Vector3.right * movespeed * Time.deltaTime);

        //StartCoroutine(DelayAction(delayTime));

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


    //IEnumerator DelayAction(float delayTime)
    //{
        
    //    //Wait for the specified delay time before continuing.
    //    yield return new WaitForSeconds(6f);

    //    Destroy(gameObject);
    //    //partS.SetActive(true);//Do the action after the delay time has finished.
    //}

}
