using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class NachoManager : MonoBehaviour
{
    static public NachoManager Instance; //easy access to this script and its info for other scripts

    public TextMeshProUGUI scoreText; //the text used to tell the player how well they made their nachos
    public float fadeTime = 1f; //time for text to fade away

    private float fadeTimer = 0; //timer used for fading text away

    public GameObject TrayPrefab; //prefab of trays

    public GameObject activeTray; //currently active tray

    public Transform traySpawn; //spawn location of trays

    public UnityEvent OnTrayFinished; //event called when the player sends the active tray offscreen

    private void Awake()
    {
        Instance = this; //easy access to this instance of the script and its info for other scripts
    }

    public void FinishTray() //called via button when the player wants to send active tray offscreen
    {
        int cheeseCount = 0;
        int nachoCount = 0;
        foreach (GameObject food in activeTray.GetComponent<NachoTray>().foodItems) //sum up the cheese and nachos
        {
            if (food.GetComponent<FoodItem>().foodType == FoodItem.FoodType.cheese)
            {
                cheeseCount++;
            }
            else
            {
                nachoCount++;
            }
        }

        if (cheeseCount == 0) //messy way to avoid dividing by 0 by giving a guaranteed "not enough cheese" message
        {
            nachoCount = 1000;
            cheeseCount = 1;
        }
        float nachoRatio = nachoCount / cheeseCount; //get the ratio of nacho to cheese, then give a rating based on said ratio
        if (nachoRatio == 1)
        {
            scoreText.text = "Perfect!!";
        }
        else if (nachoRatio > 1.25)
        {
            scoreText.text = "Not enough cheese...";
        }
        else if (nachoRatio < 0.75)
        {
            scoreText.text = "Too cheesy!";
        }
        else
        {
            scoreText.text = "Yum!";
        }
        StartCoroutine(NachoTextFade()); //fade the score text away over time
        OnTrayFinished.Invoke(); //call tray finish event to send tray offscreen
        activeTray = Instantiate(TrayPrefab, traySpawn.position, Quaternion.identity); //create new tray
    }

    IEnumerator NachoTextFade() //used to fade score text away
    {
        fadeTimer = 0;
        scoreText.color = new Color(0, 0, 0, 255); //set text as visible 
        while (scoreText.color.a > 0) //slowly fade until text is fully transparent
        {
            fadeTimer += Time.deltaTime;
            scoreText.color = Color.Lerp(Color.black, new Color(0, 0, 0, 0), fadeTimer / fadeTime);
            yield return null;
        }
    }
}
