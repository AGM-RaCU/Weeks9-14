using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnButton : MonoBehaviour
{
    public bool electricty = false;
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
            mousePostion.z = 0f;

            //Figure out how far the mouse is from the button's center
            float Distance = Vector3.Distance(mousePostion, transform.position);

            //if the distance is less than the radius and the mouse is being clicked
            if (Distance <= 0.5 && Input.GetMouseButtonDown(0))
            {
                OnOvenTurnedOn.Invoke();
                Debug.Log("hello world");
            }
            //TRIGGER THE EVENT
        }
    }
    public void OnClickOnPower()
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
