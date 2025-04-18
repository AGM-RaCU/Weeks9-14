using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    //Slider slider; //SLIDER VARIABLE
    //Score score; //SCORE VARIABLE
    public GameObject Marker; //MARKER VARIABLE TO SHOW WHERE THE PLAYER SHOT THE ARROW
    public float scoreValue; //SCORE VARIABLE
    public float shotsTaken; //VARIABLE COUNTING HOW MANY SHOTS THE PLAYER HAS TAKEN (MIGHT GO UNUSED???)
    public float valueX; //VARIABLE FOR ARROW SPAWN
    public float valueY; //VARIABLE FOR ARROW SPAWN

    public UnityEvent arrowShot; //UNITY EVENT VARIABLE TO SHOOT THE ARROW

    void Start()
    {
        Debug.Log("SpawnerScript"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START

        playerScore = 0;

        score = GetComponent<GameObject.Text.Confetti>(); //GET CONFETTI

        if (arrowShot == null) //CHECKING TO SEE IF ARROW HAS BEEN SHOT
            arrowShot = new UnityEvent(); //CALLING THE ARROW SHOT EVENT
        arrowShot.AddListener(ArrowShot); //ADDING THE ARROW SHOT LISTENER
        
        arrowShot.AddListener(Confetti); //ADD CONFETTI
        
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

        if (0 < sliderX.value <= 1 & 8 > sliderY.value => 7) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2 + -3; //X POSITION FOR PREFAB
            valueY = Screen.height/2 + 3; //Y POSITION FOR PREFAB
            playerScore + 1; //PLAYER SCORE INCREASE
        }
        else if (1 < sliderX.value <= 2 & 7 > sliderY.value => 6) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2 + -2; //X POSITION FOR PREFAB
            valueY = Screen.height/2 + 2; //Y POSITION FOR PREFAB
            playerScore + 2; //PLAYER SCORE INCREASE
        }
        else if (2 < sliderX.value <= 3 & 6 > sliderY.value => 5) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2 + -1; //X POSITION FOR PREFAB
            valueY = Screen.height/2 + 1; //Y POSITION FOR PREFAB
            playerScore + 3; //PLAYER SCORE INCREASE
        }
        else if (3 < sliderX.value <= 4 & 5 > sliderY.value => 4) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2; //X POSITION FOR PREFAB
            valueY = Screen.height/2; //Y POSITION FOR PREFAB
            playerScore + 4; //PLAYER SCORE INCREASE
        }
        else if (4 < sliderX.value <= 5 & 4 > sliderY.value => 3) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2; //X POSITION FOR PREFAB
            valueY = Screen.height/2; //Y POSITION FOR PREFAB
            playerScore + 4; //PLAYER SCORE INCREASE
        }
        else if (5 < sliderX.value <= 6 & 3 > sliderY.value => 2) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2 + -1; //X POSITION FOR PREFAB
            valueY = Screen.height/2 + 1; //Y POSITION FOR PREFAB
            playerScore + 3; //PLAYER SCORE INCREASE
        }
        else if (6 < sliderX.value <= 7 & 2 > sliderY.value => 1) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2 + -2; //X POSITION FOR PREFAB
            valueY = Screen.height/2 + 2; //Y POSITION FOR PREFAB
            playerScore + 2; //PLAYER SCORE INCREASE
        }
        else if (7 < sliderX.value <= 8 & 1 > sliderY.value => 0) //CHECK THE SLIDER VALUE
        {
            valueX = Screen.width/2 + -3; //X POSITION FOR PREFAB
            valueY = Screen.height/2 + 3; //Y POSITION FOR PREFAB
            playerScore + 1; //PLAYER SCORE INCREASE
        }

        Instantiate(Marker, valueX, valueY); //INSTANTIATE THE MARKER PREFAB, MAKES THE ARROW SHOT MARKER APPEAR IN THE CO-ORDINATE

        Debug.Log("Arrow Shot"); //DEBUG LOG TO SHOW ME WHEN ARROW HAS BEEN SHOT
    }

}
