using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float coinSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        //implicit on compoenents. trasform is component, and rotate around is a function of that component. New vector object created
        //time is a class, deltatime is a specific amount of time, times coinspeed
        Vector3 cc = new Vector3(0, 1, 0);
        this.transform.RotateAround(transform.position,
          cc, Time.deltaTime * coinSpeed);
    }
}
