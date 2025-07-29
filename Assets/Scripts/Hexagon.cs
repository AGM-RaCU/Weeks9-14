using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Hexagon : MonoBehaviour
{
    //declaring an ervent which we can then invoke and get other objects toi do things

    //when the colour is changed, anything listening to this event will run the corresponding method

    public UnityEvent onColourChange;
    public TMP_Text counterText;
    private SpriteRenderer hexagonRenderer;

    // Start is called before the first frame update
    void Start()
    {
        hexagonRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnColourClick()
    {
        hexagonRenderer.color = Random.ColorHSV();

        //use invoke whenever the event is supposed to tell other things to do something
        //we're changing color in this method, so everything that's listening to onColourChange is now supposed to do something
        onColourChange.Invoke();
        //Increase the counter
    }


}
