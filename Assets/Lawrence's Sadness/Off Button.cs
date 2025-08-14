using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class OffButton : MonoBehaviour
{
    bool electricty = false;
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
                OnOvenTurnedOff.Invoke();
            }
                //TRIGGER THE EVENT
        }
    }
    public void OnClickOffPower()
    {
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
