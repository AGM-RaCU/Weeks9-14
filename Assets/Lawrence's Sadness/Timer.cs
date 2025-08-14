using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Timer : MonoBehaviour
{
    //unused boolean for electricty (feels right to have the timer connected to electricty even if it isn't required for functionality
    public bool electricty = false;
    //Corutine for the clock
    Coroutine clockRoutine;
    //helps you turn on and off the timer, ensure only one coroutine is running at a time
    public bool running = false;
    //Events to change the state of the nachos (overlays an image)
    public UnityEvent Melt;
    public UnityEvent Burn;

    //Slider variables
    public Slider timeSlider;
    public float maxTime = 100f;
    public float time = 0f;
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
    //Coroutine for timer
    public IEnumerator Clock()
    {
        while(true)
        {
            //Have a timer
            //timer increases
            time += Time.deltaTime;
            //slider is being updated between 0 - 1
            timeSlider.value = time/maxTime;
            //if time is 40/100 melt the cheese
            if(time > 40f)
            {
                //FIRE THE EVENT
                Melt.Invoke();
            }
            //if you're at 30%
            //fire an event
            //if timer is at 60/100 burn the cheese
            if(time > 60f)
            {
                Burn.Invoke();
            }
            //if you're at 60%
            //fire a different event
            //this lets the coroutine run without needing a hard stop
            yield return null;
        }




    }
    //Connects to the On button for starting the coroutine
    public void OnClickStart()
    {
        if (running == false)
        {
            clockRoutine = StartCoroutine(Clock());
            running = true;
        }
    }
    //Connects to the Off button for stopping the coroutine
    public void OnClickStop()
    {
        if (running == true)
        {
            StopCoroutine(clockRoutine);
            running = false;
        }
    }
}
