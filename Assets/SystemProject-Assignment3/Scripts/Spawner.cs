using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject Marker;
    public float scoreValue;
    public float shotsTaken;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown())
        {
            Instantiate(Marker, valueX, valueY);
        }
    }
}
