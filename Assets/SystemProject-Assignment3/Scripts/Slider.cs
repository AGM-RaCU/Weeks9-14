using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Slider : MonoBehaviour
{
    public GameObject sliderX;
    public GameObject sliderY;
    public float valueX;
    public float valueY;

    void Start()
    {
        valueX = GetComponent<Slider X.value>();
        valueY = GetComponent<Slider Y.value>();
    }

    void Update()
    {
        
    }
}
