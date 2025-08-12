using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachoTray : MonoBehaviour
{
    public List<GameObject> foodItems = new List<GameObject>();
    public float leavingSpeed = 20f;
    public float enterSpeed = 5f;
    public float startHeight;
    // Start is called before the first frame update
    void Start()
    {
        NachoManager.Instance.OnTrayFinished.AddListener(CallLeaveScene);
        StartCoroutine(EnterScene());
    }
    public IEnumerator LeaveScene()
    {
        while (transform.position.x < 12)
        {
            transform.position += Vector3.right * Time.deltaTime * leavingSpeed;
            yield return null;
        }
        Destroy(gameObject);
    }

    public IEnumerator EnterScene()
    {
        while (transform.position.y < startHeight)
        {
            transform.position += Vector3.up * Time.deltaTime * enterSpeed;
            yield return null;
        }
    }

    public void CallLeaveScene()
    {
        StartCoroutine(LeaveScene());
        NachoManager.Instance.OnTrayFinished.RemoveListener(CallLeaveScene);
    }
}
