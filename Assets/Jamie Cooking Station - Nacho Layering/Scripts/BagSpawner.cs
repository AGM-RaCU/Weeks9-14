using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagSpawner : MonoBehaviour
{
    public float returnSpeed; //speed the bag returns to its starting position
    public float spawnFreq; //frequency food items are spawned

    public GameObject SpawnedItem; //item to be spawned

    public enum state {held,resting,returning};
    public state currState; //current state of the bag

    private Vector3 startPos; //position the bag started at

    private float spawnTimer; //time since last spawning food
    private void Start() //set default state, save position, make spawn timer set to frequency so right clicking will immediately spawn an item when the player picks it up
    {
        currState = state.resting;
        startPos = transform.position;
        spawnTimer = spawnFreq;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //get adjusted mouse position for use in checking if the player is clicking on this and moving with mouse
        mouseWorldPos.z = 0;

        switch (currState)
        {
            case state.resting:
                if (Input.GetMouseButtonDown(0) && Vector3.Distance(transform.position, mouseWorldPos) < transform.localScale.y/2) //if player clicks on this, set state to held
                {
                    currState = state.held;
                }
                break;
            case state.held: //if held, if player lets go of mouse, set state to returning, otherwise, if player is holding right click, spawn food every spawn frequency seconds. regardless, set the position of this to the mouse position.
                if (Input.GetMouseButtonUp(0))
                {
                    currState = state.returning;
                    StartCoroutine(Return()); //start returning to start position
                }
                if (Input.GetMouseButton(1) && spawnTimer>=spawnFreq)
                {
                    spawnTimer = 0f;
                    Instantiate(SpawnedItem,transform.position,Quaternion.identity);
                }
                spawnTimer += Time.deltaTime;
                transform.position = mouseWorldPos;
                break;
            case state.returning: //if returning, dont do either of the above. 
                break;
        }
    }

    public IEnumerator Return()
    {
        spawnTimer = spawnFreq; //reset spawn timer
        while (Vector3.Distance(transform.position, startPos) > 0.2) //while not in start position, move towards it.
        {
            transform.position += Vector3.Normalize(startPos-transform.position)*returnSpeed*Time.deltaTime;
            yield return null;
        }
        currState = state.resting; //on reaching start position, reset state to resting
    }
}
