using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Basicmover : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public bool doSpin = true;
    public bool doMotion = false;

    // Update is called once per frame
    void Update()
    {    //This helps the game object to spin
       if(doSpin)
            gameObject.transform.Rotate(Vector3.up*spinSpeed*Time.deltaTime);
        //To move the game object
        if(doMotion)
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad)*motionMagnitude);
    }
}
