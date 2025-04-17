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

    void Start()
    {
        Debug.Log("SpawnerScript"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START
    }

    void Update()
    {
        //Debug.Log("SpawnerUpdate"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING UPDATE
        if (Input.GetMouseButtonDown(0)) //IF STATEMENT FOR MOUSE CLICK CONTROL
        {
            //Instantiate(Marker, valueX, valueY); //INSTANTIATE THE MARKER PREFAB, MAKES THE ARROW SHOT MARKER APPEAR IN THE CO-ORDINATE
            //SET THE PLAYER SCORE
            //ADD TO THE PLAYER SCORE
            Debug.Log("Mouse"); //DEBUG LOG TO SHOW ME WHEN THE MOUSE IS CLICKED AND CONFIRM THE MOUSE FUNCTION IS WORKING
        }
    }
}
