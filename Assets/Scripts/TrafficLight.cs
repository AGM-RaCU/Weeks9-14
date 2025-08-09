using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Go()
    {
            trafficLightRenderer.color = Color.green;
    }

    public void Stop()
    {
            trafficLightRenderer.color = Color.red;
    }
}