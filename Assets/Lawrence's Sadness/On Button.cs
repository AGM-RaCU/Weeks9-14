using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButton : MonoBehaviour
{
    bool electricty = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
