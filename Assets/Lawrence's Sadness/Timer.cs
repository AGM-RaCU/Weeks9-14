using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Timer : MonoBehaviour
{
    public bool electricty = false;
    Coroutine clockRoutine;
    public bool running = false;

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
    public IEnumerator Clock()
    {
        while(true)
        {
            //Have a timer
            //timer increases
            time += Time.deltaTime;
            //slider is being updated between 0 - 1
            timeSlider.value = time/maxTime;

            if(time > 40f)
            {
                //FIRE THE EVENT
                Melt.Invoke();
            }
            //if you're at 30%
            //fire an event

            if(time > 60f)
            {
                Burn.Invoke();
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
            Debug.Log("turned on");
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
