using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RaCU
{
    public class ToppingSpawnerRaCU : MonoBehaviour
    {
        public GameObject TomatoPrefab;
        public GameObject OnionPrefab;
        public GameObject LettucePrefab;
        public GameObject CilantroPrefab;
        public GameObject SaucePrefab;
        public GameObject HotSaucePrefab;
        public GameObject Plate;

        public void placeTomato()
        {
            GameObject Tomato = Instantiate(TomatoPrefab);
            Tomato.transform.parent = transform;
        }

        public void placeOnion()
        {
            GameObject Onion = Instantiate(OnionPrefab);
            Onion.transform.parent = transform;
        }

        public void placeLettuce()
        {
            GameObject Lettuce = Instantiate(LettucePrefab);
            Lettuce.transform.parent = transform;
        }

        public void placeCilantro()
        {
            GameObject Cilantro = Instantiate(CilantroPrefab);
            Cilantro.transform.parent = transform;
        }

        public void placeSauce()
        {
            GameObject Sauce = Instantiate(SaucePrefab);
            Sauce.transform.parent = transform;
        }

        public void placeHotSauce()
        {
            GameObject HotSauce = Instantiate(HotSaucePrefab);
            HotSauce.transform.parent = transform;
        }

        public void plateConnect()
        {
            transform.position = Plate.transform.position;
        }
    }
}
