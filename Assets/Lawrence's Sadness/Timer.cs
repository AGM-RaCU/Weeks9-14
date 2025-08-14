using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool electricty = false;
    public float time;
    Coroutine clockRoutine;
    public bool running = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickTPower()
    {
        if (electricty == false)
        {
            electricty = true;
        } else if (electricty == true)
        {
            electricty = false;
        }

    }
    public IEnumerator Clock()
    {
        while(true)
        {
            //Have a timer
            //timer increases

            //slider is being updated between 0 - 1

            if(time > 3)
            {
                //FIRE THE EVENT
            }
            //if you're at 30%
            //fire an event

            if(time > 6)
            {

            }
            //if you're at 60%
            //fire a different event
            yield return null;
        }




    }
    public void OnClickStart()
    {
        if (running == false)
        {
            clockRoutine = StartCoroutine(Clock());
            running = true;
        }
    }
    public void OnClickStop()
    {
        if (running == true)
        {
            StopCoroutine(clockRoutine);
            running = false;
        }
    }
}
