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
        
        Debug.Log("ScoreScript"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING START
    }

    void Update()
    {
        scoreCount = GetComponent<board1.Spawner.playerScore>() //UPDATE SCORE COUNT
        Debug.Log("ScoreUpdate"); //DEBUG LOG TO SHOW ME WHEN THIS SCRIPT HAPPENS DURING UPDATE
    }

    public void Confetti()
    {
        private IEnumerator confetti; //SPAWN CONFETTI COROUTINE
    GetComponent<Confetti>(); //CONFETTI PREFAB
        Debug.Log("Confetti"); //DEBUG LOG TO SHOW ME IF THIS SCRIPT IS BEING READ
    }
    
}
