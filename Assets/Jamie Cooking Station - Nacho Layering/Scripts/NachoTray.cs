using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachoTray : MonoBehaviour
{
    public List<GameObject> foodItems = new List<GameObject>(); //list of food items on this tray
    public float leavingSpeed = 20f; //speed of leaving the scene
    public float enterSpeed = 5f; //speed of entering from below
    public float startHeight; //height above the spawn location the tray moves to
    public Vector2 catchDistance; //distance in x and y which the tray will catch food items at
    // Start is called before the first frame update
    void Start()
    {
        NachoManager.Instance.OnTrayFinished.AddListener(CallLeaveScene); //when the tray is finished, leave the scene
        StartCoroutine(EnterScene()); //used to move tray into view from offscreen
    }
    public IEnumerator LeaveScene()
    {
        while (transform.position.x < 12) //move offscreen right
        {
            transform.position += Vector3.right * Time.deltaTime * leavingSpeed;
            yield return null;
        }
        Destroy(gameObject); //when offscreen, destroy this
    }

    public IEnumerator EnterScene() //move onscreen from below
    {
        while (transform.position.y < startHeight)
        {
            transform.position += Vector3.up * Time.deltaTime * enterSpeed;
            yield return null;
        }
    }

    public void CallLeaveScene()  //called on the unity event in NachoManager which is activated when a button is pressed to send the tray offscreen
    {
        StartCoroutine(LeaveScene());
        NachoManager.Instance.OnTrayFinished.RemoveListener(CallLeaveScene); //in case the button gets spammed
    }
}
