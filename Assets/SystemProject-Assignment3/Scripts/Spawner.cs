using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    Slider slider;
    public GameObject Marker;
    public float scoreValue;
    public float shotsTaken;

    void Start()
    {
        Debug.Log("SpawnerScript");
    }

    void Update()
    {
        //Debug.Log("SpawnerUpdate");
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(Marker, valueX, valueY);
            //SET SCORE
            //UPDATE SCORE
            Debug.Log("Mouse");
        }
    }
}
