using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlateMoverRaCU : MonoBehaviour
{

    public UnityEvent goButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed()
    {
        StartCoroutine(movePlate());
    }

    public IEnumerator movePlate()
    {
        yield return null;
    }
}
