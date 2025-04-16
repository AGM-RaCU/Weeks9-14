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
        float valueX = GetComponent<sliderX.value>();
        float valueY = GetComponent<sliderY.value>();
    }

    void Update()
    {
        
    }
}
