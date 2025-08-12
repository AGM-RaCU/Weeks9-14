using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToppingSpawnerRaCU : MonoBehaviour
{
    public GameObject TomatoPrefab;
    public GameObject OnionPrefab;
    public GameObject LettucePrefab;
    public GameObject CilantroPrefab;
    public GameObject SaucePrefab;
    public GameObject HotSaucePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeTomato()
    {
        Instantiate(TomatoPrefab);
    }

    public void placeOnion()
    {
        Instantiate(OnionPrefab);
    }

    public void placeLettuce()
    {
        Instantiate(LettucePrefab);
    }

    public void placeCilantro()
    {
        Instantiate(CilantroPrefab);
    }

    public void placeSauce()
    {
        Instantiate(SaucePrefab);
    }

    public void placeHotSauce()
    {
        Instantiate(HotSaucePrefab);
    }
}
