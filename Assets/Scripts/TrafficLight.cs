using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    private SpriteRenderer trafficLightRenderer;

    // Start is called before the first frame update
    void Start()
    {
        trafficLightRenderer = GetComponent<SpriteRenderer>();
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