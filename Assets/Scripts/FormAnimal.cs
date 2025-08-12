using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormAnimal : MonoBehaviour
{
    public float formDuration = 4f;
    private float timeInForm = 0f;

    public void ChangeForm()
    {
        Debug.Log("We are changing form");
    }

    public void FormUpdate()
    {
        timeInForm += Time.deltaTime;
        if (timeInForm > formDuration)
        {
            ChangeForm();
        }
    }
}
