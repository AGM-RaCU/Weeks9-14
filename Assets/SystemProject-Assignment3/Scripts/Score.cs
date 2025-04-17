using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public float scoreCount; //PLAYER SCORE COUNT VARIABLE
    public GameObject Particles; //PARTICLE OBJECT FOR THE CONFETTI

    void Start()
    {
        //DISPLAY SCORE COUNT 
        Debug.Log("ScoreScript"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START
    }

    void Update()
    {
        //UPDATE SCORE COUNT
        //Debug.Log("ScoreUpdate"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING UPDATE
    }

    //VOID ON CLICK EVENT - SPAWN CONFETTI COROUTINE
}
