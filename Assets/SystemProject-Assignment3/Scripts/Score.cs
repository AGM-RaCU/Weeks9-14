using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public float scoreCount;
    public GameObject Particles;

    void Start()
    {
        //DISPLAY SCORE COUNT 
        Debug.Log("ScoreScript");
    }

    void Update()
    {
        //UPDATE SCORE COUNT
        //Debug.Log("ScoreUpdate");
    }

    //VOID ON CLICK EVENT - SPAWN CONFETTI COROUTINE
}
