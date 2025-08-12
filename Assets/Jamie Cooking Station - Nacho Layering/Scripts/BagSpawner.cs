using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagSpawner : MonoBehaviour
{
    public float returnSpeed;
    public float spawnFreq;

    public GameObject SpawnedItem;

    public enum state {held,resting,returning};
    public state currState;

    private Vector3 startPos;

    private float spawnTimer;
    private void Start()
    {
        currState = state.resting;
        startPos = transform.position;
        spawnTimer = spawnFreq;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;

        switch (currState)
        {
            case state.resting:
                if (Input.GetMouseButtonDown(0) && Vector3.Distance(transform.position, mouseWorldPos) < transform.localScale.y/2)
                {
                    currState = state.held;
                }
                break;
            case state.held:
                if (Input.GetMouseButtonUp(0))
                {
                    currState = state.returning;
                    StartCoroutine(Return());
                }
                if (Input.GetMouseButton(1) && spawnTimer>=spawnFreq)
                {
                    spawnTimer = 0f;
                    Instantiate(SpawnedItem,transform.position,Quaternion.identity);
                }
                spawnTimer += Time.deltaTime;
                transform.position = mouseWorldPos;
                break;
            case state.returning:
                break;
        }
    }

    public IEnumerator Return()
    {
        spawnTimer = spawnFreq;
        while (Vector3.Distance(transform.position, startPos) > 0.1)
        {
            transform.position += Vector3.Normalize(startPos-transform.position)*returnSpeed*Time.deltaTime;
            yield return null;
        }
        currState = state.resting;
    }
}
