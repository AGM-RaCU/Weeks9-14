using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SliderMarker : MonoBehaviour
{
    public Slider sliderX; //SLIDER X OBJECT VARIABLE
    public Slider sliderY; //SLIDER Y OBJECT VARIABLE
   

    void Start()
    {
     
        sliderX.value = 4.0f; //STARTING THE X SLIDER IN THE MIDDLE
        sliderY.value = 4.0f; //STARTING THE Y SLIDER IN THE MIDDLE
        Debug.Log("Programa Empieza"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START
    }

    void Update()
    {
        if (sliderX.value < 8 & sliderY.value > 0) //IF STATEMENTS TO MAKE THE SLIDER VALUES POSITIVE
        {
            sliderX.value += 0.3f; //INCREASE RATE FOR THE VALUE OF SLIDER X SO IT GOES RIGHT
            sliderY.value += -0.3f; //DECREASE RATE FOR THE VALUE OF SLIDER Y SO IT GOES DOWN
        }
        else if (sliderX.value >= 8 & sliderY.value <= 0) //IF STATEMENTS TO MAKE THE SLIDER VALUES NEGATIVE
        {
            sliderX.value = 0.0f; //RESET THE VALUE OF SLIDER X
            sliderY.value = 8.0f; //RESET THE VALUE OF SLIDER Y
        }
     

       Debug.Log("MarkerUpdate"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING UPDATE, AS WELL AS DELTA TIME AND MY SLIDER VALUES
    }



}
