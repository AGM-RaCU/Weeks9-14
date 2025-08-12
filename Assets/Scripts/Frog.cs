using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : FormAnimal
{
    public enum Form
    { 
        egg, tadpole, frog
    }

    public Form currentForm = Form.egg;

    private void Update()
    {
        {
            FormUpdate();
        }
    }

    //void FormUpdate()
    //{
        //timeInForm += Time.deltaTime;
        //if (timeInForm > formDuration)
        //{
           // ChangeForm();
        //}
    //}

    //void ChangeForm()
    //{
        //if (currentForm == Form.caterpillar)
        //{
            //timeInForm = 0f;
            //currentForm = Form.cocoon;
            //Debug.Log("Changing form to Cocoon");
            //butterflyModule.startColor = cocoonGradient;
       // }
        //else if (currentForm == Form.cocoon)
       // {
          //  timeInForm = 0f;
           // currentForm = Form.butterfly;
          //  Debug.Log("Changing form to Butterfly");
           // butterflyModule.startColor = butterflyGradient;
        //}
    //}
}
