using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class OffButton : MonoBehaviour
{
    //bool to determine if button is being powered
    bool electricty = false;
    //Unity Event for button functionality
    public UnityEvent OnOvenTurnedOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (electricty == true)
        {
            //Find the mouse position 
            Vector3 mousePostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePostion.z = 0f;

            //Figure out how far the mouse is from the button's center
            float Distance = Vector3.Distance(mousePostion, transform.position);
            

            //if the distance is less than the radius and the mouse is being clicked
            if (Distance <=0.5 && Input.GetMouseButtonDown(0))
            {
                //Inviokes the Event that Stops the Oven Coroutin
                OnOvenTurnedOff.Invoke();
            }
                //TRIGGER THE EVENT
        }
    }
    public void OnClickOffPower()
    {
        //switches between electricty is one and off
        if (electricty == false)
        {
            electricty = true;
        }
        else if (electricty == true)
        {
            electricty = false;
        }

    }
}
