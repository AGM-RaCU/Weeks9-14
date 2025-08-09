using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrafficLightController : MonoBehaviour
{
    private SpriteRenderer trafficLightRenderer;
    public UnityEvent lightGo;
    public UnityEvent lightStop;

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
        if (Input.GetMouseButtonDown(0))
        {
            trafficLightRenderer.color = Color.green;
            lightGo.Invoke();
        }
    }

    public void Stop()
    {
        if (Input.GetMouseButtonDown(1))
        {
            trafficLightRenderer.color = Color.red;
            lightStop.Invoke();
        }
    }
}
