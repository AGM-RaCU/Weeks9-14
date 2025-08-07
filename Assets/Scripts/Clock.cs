using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Clock : MonoBehaviour
{
    public Transform hourHand, minuteHand;

    public Chime chime;

    public UnityEvent<int> onHourReached;

    public float hourDuration = 4f;

    private float currentTime = 0f;

    private Coroutine activeClockCoroutine;

    private IEnumerator activeHandsCoroutine;

    private int currentHour = 0;

    // Start is called before the first frame update
    void Start()
    {
        chime = gameObject.GetComponentInChildren<Chime>();
        //Debug.Log("Do I have a chime?[" + chime + "]");

        activeClockCoroutine = StartCoroutine(ClockUpdate());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stop()
    {
        if (activeClockCoroutine != null)
        {
            StopCoroutine(activeClockCoroutine);
        }

        if (activeHandsCoroutine != null)
        {
            StopCoroutine(activeHandsCoroutine);
        }
    }

    IEnumerator ClockUpdate()
    {
        while(true)
        {
            activeHandsCoroutine = MoveHandsAnHour();
            yield return StartCoroutine(activeHandsCoroutine);
        }

        Debug.Log("We've finished ClockUpdate coroutine");
    }

    IEnumerator MoveHandsAnHour()
    {
        currentTime = 0f;
        while (currentTime < hourDuration)
        {
            currentTime += Time.deltaTime;

            minuteHand.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration;

            hourHand.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration / 12;

            if (currentTime > hourDuration)
            {
                if (chime == null)
                {
                    Debug.Log("Theres no chime assigned as a child of the object");
                }
                else
                {
                    currentHour++;
                    onHourReached.Invoke(currentHour);
                }
            }

            yield return null;
        }

        Debug.Log("We've finished MoveHandsAnHour coroutine");
    }
}
