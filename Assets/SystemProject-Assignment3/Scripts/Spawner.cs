using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    Slider slider; //SLIDER VARIABLE
    Score score;
    public GameObject Marker; //MARKER VARIABLE TO SHOW WHERE THE PLAYER SHOT THE ARROW
    public float scoreValue; //SCORE VARIABLE
    public float shotsTaken; //VARIABLE COUNTING HOW MANY SHOTS THE PLAYER HAS TAKEN (MIGHT GO UNUSED???)
   
    public UnityEvent arrowShot; //UNITY EVENT VARIABLE TO SHOOT THE ARROW

    void Start()
    {
        Debug.Log("SpawnerScript"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START
        
        score = GetComponent<GameObject.Text>();
        
        if (arrowShot == null) //CHECKING TO SEE IF ARROW HAS BEEN SHOT
            arrowShot = new UnityEvent(); //CALLING THE ARROW SHOT EVENT
        arrowShot.AddListener(ArrowShot); //ADDING THE ARROW SHOT LISTENER
        
        arrowShot.AddListener(Confetti);
        
        Debug.Log("ARL added"); //DEBUG LOG TO SHOW ME WHEN THE ARROW SHOT LISTENER IS ADDED
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && arrowShot != null) //CHECKING TO SEE IF MOUSE IS CLICKED AND ARROW HAS BEEN SHOT
        {
            arrowShot.Invoke(); //INVOKE ARROW SHOT EVENT
            
            Debug.Log("Mouse"); //DEBUG LOG TO SHOW ME WHEN THE MOUSE IS CLICKED AND CONFIRM THE MOUSE FUNCTION IS WORKING
        }

    }

    void ArrowShot()
    {
        //    //Instantiate(Marker, valueX, valueY); //INSTANTIATE THE MARKER PREFAB, MAKES THE ARROW SHOT MARKER APPEAR IN THE CO-ORDINATE[[[[[[[[[[[[[[
        //    //SET THE PLAYER SCORE[[[[[[[[[[[[
        //    //ADD TO THE PLAYER SCORE[[[[[[[[[[[[
        if (0 < sliderX.value <= 1 & 8 > sliderY.value >= 7)
        {

        }
        else if (1 < sliderX.value <= 2 & 7 > sliderY.value => 6)
        {

        }
        else if (2 < sliderX.value <= 3 & 6 > sliderY.value => 5)
        {

        }
        else if (3 < sliderX.value <= 4 & 5 > sliderY.value => 4)
        {

        }
        else if (4 < sliderX.value <= 5 & 4 > sliderY.value => 3)
        {

        }
        else if (5 < sliderX.value <= 6 & 3 > sliderY.value => 2)
        {

        }
        else if (6 < sliderX.value <= 7 & 2 > sliderY.value => 1)
        {

        }
        else if (7 < sliderX.value <= 8 & 1 > sliderY.value => 0)
        {

        }
        Debug.Log("Arrow Shot"); //DEBUG LOG TO SHOW ME WHEN ARROW HAS BEEN SHOT
    }

}
