using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrafficLightController : MonoBehaviour
{
    public UnityEvent lightGo;
    public UnityEvent lightStop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lightGo.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
            lightStop.Invoke();
        }
    }

}
