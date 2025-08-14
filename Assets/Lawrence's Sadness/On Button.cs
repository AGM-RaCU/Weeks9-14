using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnButton : MonoBehaviour
{
    //bool to determine if the button is being pressed
    public bool electricty = false;
    //Unity Event fr turning oven on button press
    public UnityEvent OnOvenTurnedOn;
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
            //set the mouse position to 0 instead of 10 away from origin
            mousePostion.z = 0f;

            //Figure out how far the mouse is from the button's center
            float Distance = Vector3.Distance(mousePostion, transform.position);

            //if the distance is less than the radius and the mouse is being clicked
            if (Distance <= 0.5 && Input.GetMouseButtonDown(0))
            {
                //Invoke the Oven event that turns on the coroutine when the "button" is being pressed
                OnOvenTurnedOn.Invoke();
            }
            //TRIGGER THE EVENT
        }
    }
    public void OnClickOnPower()
    {
        //this switches on and off the power based on the click of the electricty button
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
