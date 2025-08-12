using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class NachoManager : MonoBehaviour
{
    static public NachoManager Instance;

    public TextMeshProUGUI scoreText;
    public float fadeTime = 1f;
    private float fadeTimer = 0;

    public GameObject TrayPrefab;
    public GameObject activeTray;

    public Transform traySpawn;

    public UnityEvent OnTrayFinished;

    private void Awake()
    {
        Instance = this;
    }

    public void FinishTray()
    {
        int cheeseCount = 0;
        int nachoCount = 0;
        foreach (GameObject food in activeTray.GetComponent<NachoTray>().foodItems)
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
        float nachoRatio = nachoCount / cheeseCount;
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
        StartCoroutine(NachoTextFade());
        OnTrayFinished.Invoke();
        activeTray = Instantiate(TrayPrefab, traySpawn.position, Quaternion.identity);
    }

    IEnumerator NachoTextFade()
    {
        fadeTimer = 0;
        scoreText.color = new Color(0, 0, 0, 255);
        while (scoreText.color.a > 0)
        {
            fadeTimer += Time.deltaTime;
            Debug.Log("fading");
            scoreText.color = Color.Lerp(Color.black, new Color(0, 0, 0, 0), fadeTimer / fadeTime);
            yield return null;
        }
    }
}
