using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SliderMarker : MonoBehaviour
{
    public Slider sliderX;
    public Slider sliderY;
    public float valueX;
    public float valueY;

    void Start()
    {
        valueX = sliderX.value;
        valueY = sliderY.value;
        Debug.Log("Programa Empieza");
    }

    void Update()
    {
        //Debug.Log("MarkerUpdate");
    }

    //VOID ON CLICK EVENT
        //MARK X COORD
        //MARK Y COORD
        //DETERMINE SCORE INCREASE
}
