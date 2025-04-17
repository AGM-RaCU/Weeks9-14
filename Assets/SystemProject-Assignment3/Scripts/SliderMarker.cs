using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SliderMarker : MonoBehaviour
{
    public Slider sliderX; //SLIDER X OBJECT VARIABLE
    public Slider sliderY; //SLIDER Y OBJECT VARIABLE
    //private IEnumerator markerMovement;
    //public float valueX;
    //public float valueY;

    void Start()
    {
        //valueX = sliderX.value;
        //valueY = sliderY.value;
        Debug.Log("Programa Empieza"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START
    }

    void Update()
    {
        if (sliderX.value < 8 & sliderY.value < 8) //IF STATEMENTS TO MAKE THE SLIDER VALUES POSITIVE
        {
            sliderX.value += 0.3f; //INCREASE RATE FOR THE VALUE OF SLIDER X
            sliderY.value += 0.3f; //INCREASE RATE FOR THE VALUE OF SLIDER Y
        }
        else if (sliderX.value >= 8 & sliderY.value >= 8) //IF STATEMENTS TO MAKE THE SLIDER VALUES NEGATIVE
        {
            sliderX.value += -0.3f; //DECREASE RATE FOR THE VALUE OF SLIDER X
            sliderY.value += -0.3f; //DECREASE RATE FOR THE VALUE OF SLIDER Y
        }
        //markerMovement = MarkerMovement();
        //StartCoroutine(markerMovement);

        Debug.Log("MarkerUpdate" + " " + Time.deltaTime + " " + sliderX.value + " " + sliderY.value); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING UPDATE, AS WELL AS DELTA TIME AND MY SLIDER VALUES
    }

    //VOID ON CLICK EVENT
        //MARK X COORD
        //MARK Y COORD
        //DETERMINE SCORE INCREASE //IF STATEMENTS THAT STATE HOW MUCH THE SCORE INCREASES DEPENDING ON THE SLIDER VALUES ("X & Y CO-ORDINATES")

//private IEnumerator MarkerMovement()
//    {
//        if (sliderX.value < 8 & sliderY.value < 8) //IF STATEMENTS TO MAKE THE SLIDER VALUES POSITIVE
//        {
//            sliderX.value += 0.3f; //INCREASE RATE FOR THE VALUE OF SLIDER X
//            sliderY.value += 0.3f; //INCREASE RATE FOR THE VALUE OF SLIDER Y
//        }
//        else if (sliderX.value >= 8 & sliderY.value >= 8) //IF STATEMENTS TO MAKE THE SLIDER VALUES NEGATIVE
//        {
//            sliderX.value += -0.3f; //DECREASE RATE FOR THE VALUE OF SLIDER X
//            sliderY.value += -0.3f; //DECREASE RATE FOR THE VALUE OF SLIDER Y
//        }
//    }
}
