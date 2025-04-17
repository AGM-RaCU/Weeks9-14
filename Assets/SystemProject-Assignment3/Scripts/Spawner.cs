using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    Slider slider; //SLIDER VARIABLE
    public GameObject Marker; //MARKER VARIABLE TO SHOW WHERE THE PLAYER SHOT THE ARROW
    public float scoreValue; //SCORE VARIABLE
    public float shotsTaken; //VARIABLE COUNTING HOW MANY SHOTS THE PLAYER HAS TAKEN (MIGHT GO UNUSED???)
    UnityEvent arrowShot; //UNITY EVENT VARIABLE TO SHOOT THE ARROW

    void Start()
    {
        Debug.Log("SpawnerScript"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START
        if (arrowShot == null) //CHECKING TO SEE IF ARROW HAS BEEN SHOT
            arrowShot = new UnityEvent(); //CALLING THE ARROW SHOT EVENT
        arrowShot.AddListener(ArrowShot); //ADDING THE ARROW SHOT LISTENER
        Debug.Log("ARL added"); //DEBUG LOG TO SHOW ME WHEN THE ARROW SHOT LISTENER IS ADDED
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && arrowShot != null) //CHECKING TO SEE IF MOUSE IS CLICKED AND ARROW HAS BEEN SHOT
        {
            arrowShot.Invoke(); //INVOKE ARROW SHOT EVENT
        }
        //Debug.Log("SpawnerUpdate"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING UPDATE
        //if (Input.GetMouseButtonDown(0)) //IF STATEMENT FOR MOUSE CLICK CONTROL
        //{
        //    //Instantiate(Marker, valueX, valueY); //INSTANTIATE THE MARKER PREFAB, MAKES THE ARROW SHOT MARKER APPEAR IN THE CO-ORDINATE
        //    //SET THE PLAYER SCORE
        //    //ADD TO THE PLAYER SCORE
        //    Debug.Log("Mouse"); //DEBUG LOG TO SHOW ME WHEN THE MOUSE IS CLICKED AND CONFIRM THE MOUSE FUNCTION IS WORKING
        //}
    }

    void ArrowShot()
    {
        Debug.Log("Arrow Shot"); //DEBUG LOG TO SHOW ME WHEN ARROW HAS BEEN SHOT
    }
}
