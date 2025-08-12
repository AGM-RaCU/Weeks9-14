using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public enum FoodType {nacho,cheese}; 
    public FoodType foodType;//used to tell other scripts which type of food this item is

    public float fallSpeed; //speed this item falls when dropped from the bag
    public float lifetime; //duration before this item deletes itself

    private float timeSinceSpawn; //used to track how long this item has been active

    private Coroutine activeFallCoroutine; //holds the falling co routine so we can stop it later

    private bool landed = false; //used to track when this item lands on other food or the tray
    // Start is called before the first frame update
    void Start()
    {
        activeFallCoroutine = StartCoroutine(Fall()); //start falling
        StartCoroutine(KillCoroutine()); //start tracking time since spawn, kill this if we havent landed by when we reach our max lifetime
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360)); //set a random rotation for some variance visually
    }

    private IEnumerator Fall() //makes this item fall until it lands on other food or the tray
    {
        while (!landed) //continue until we land
        {
            transform.position -= Vector3.up * fallSpeed*Time.deltaTime; //the actual motion

            GameObject activeTray = NachoManager.Instance.activeTray; //get reference to active tray from nachomanager. we do this each frame in case active trays are changed while this item is falling
            if (activeTray != null) //null check to ensure we dont throw errors
            {
                landed = (Mathf.Abs(transform.position.x - activeTray.transform.position.x) < activeTray.transform.localScale.x / 2) && (Mathf.Abs(transform.position.y - activeTray.transform.position.y) < activeTray.transform.localScale.y / 2); //if we are within range of the tray both in x and y axis, we have landed
                foreach (GameObject food in activeTray.GetComponent<NachoTray>().foodItems)
                {
                    landed = landed || Vector3.Distance(transform.position, food.transform.position) < transform.localScale.x/2; //we can also count as having landed if we are near other food
                }
            }            
            yield return null;
        }
        GameObject activeTrayOnEnd = NachoManager.Instance.activeTray; //since we regrab the active tray each frame in our loop, we need new reference to it
        if(activeTrayOnEnd != null) //quick null check in case we somehow grab it when it doesnt exist. 
        {
            activeTrayOnEnd.GetComponent<NachoTray>().foodItems.Add(gameObject); //add ourselves to the tray
            transform.SetParent(activeTrayOnEnd.transform); //parent ourselves to the tray so we move offscreen with it later, and get the funky scaling effect on landing
        }
    }

    private IEnumerator KillCoroutine() //tracks lifetime
    {
        while(timeSinceSpawn < lifetime)
        {
            timeSinceSpawn += Time.deltaTime; //timer
            yield return null;
        }
        if (!landed) //on timer ending, end falling coroutine and destroy this.
        {
            StopCoroutine(activeFallCoroutine);
            Destroy(gameObject);
        }
    }
}
