using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public enum FoodType {nacho,cheese};
    public FoodType foodType;

    public float fallSpeed;
    public float lifetime;

    private float timeSinceSpawn;

    private Coroutine activeFallCoroutine;

    private bool landed = false;
    // Start is called before the first frame update
    void Start()
    {
        activeFallCoroutine = StartCoroutine(Fall());
        StartCoroutine(KillCoroutine());
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
    }

    private IEnumerator Fall()
    {
        while (!landed)
        {
            Debug.Log("falling");
            transform.position -= Vector3.up * fallSpeed*Time.deltaTime;

            GameObject activeTray = NachoManager.Instance.activeTray;
            if (activeTray != null)
            {
                landed = (Mathf.Abs(transform.position.x - activeTray.transform.position.x) < activeTray.transform.localScale.x / 2) && (Mathf.Abs(transform.position.y - activeTray.transform.position.y) < activeTray.transform.localScale.y / 2);
                foreach (GameObject food in activeTray.GetComponent<NachoTray>().foodItems)
                {
                    landed = landed || Vector3.Distance(transform.position, food.transform.position) < transform.localScale.x/2;
                }
            }            
            yield return null;
        }
        GameObject activeTrayOnEnd = NachoManager.Instance.activeTray;
        if(activeTrayOnEnd != null)
        {
            activeTrayOnEnd.GetComponent<NachoTray>().foodItems.Add(gameObject);
            transform.SetParent(activeTrayOnEnd.transform);
        }
    }

    private IEnumerator KillCoroutine()
    {
        while(timeSinceSpawn < lifetime)
        {
            Debug.Log("running");
            timeSinceSpawn += Time.deltaTime;
            yield return null;
        }
        if (!landed)
        {
            StopCoroutine(activeFallCoroutine);
            Destroy(gameObject);
        }
    }
}
