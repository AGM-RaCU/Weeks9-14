using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RaCU
{
    public class ToppingSpawnerRaCU : MonoBehaviour
    {
        public GameObject TomatoPrefab, OnionPrefab, LettucePrefab, CilantroPrefab, SaucePrefab, HotSaucePrefab, Plate; //nacho plate and toppings

        public void placeTomato()//method to place tomato
        {
            GameObject Tomato = Instantiate(TomatoPrefab);//spawn tomato prefab
            Tomato.transform.parent = transform;//make prefab child of spawner object
        }

        public void placeOnion()//method to place onion
        {
            GameObject Onion = Instantiate(OnionPrefab);//spawn onion prefab
            Onion.transform.parent = transform;//make prefab child of spawner object
        }

        public void placeLettuce()//method to place lettuce
        {
            GameObject Lettuce = Instantiate(LettucePrefab);//spawn lettuce prefab
            Lettuce.transform.parent = transform;//make prefab child of spawner object
        }

        public void placeCilantro()//method to place cilantro
        {
            GameObject Cilantro = Instantiate(CilantroPrefab);//spawn cilantro prefab
            Cilantro.transform.parent = transform;//make prefab child of spawner object
        }

        public void placeSauce()//method to place sauce
        {
            GameObject Sauce = Instantiate(SaucePrefab);//spawn sauce prefab
            Sauce.transform.parent = transform;//make prefab child of spawner object
        }

        public void placeHotSauce()//method to place hot sauce
        {
            GameObject HotSauce = Instantiate(HotSaucePrefab);//spawn hot sauce prefab
            HotSauce.transform.parent = transform;//make prefab child of spawner object
        }

        public void plateConnect()//method to have spawner follow plate (called on button press event from other script)
        {
            transform.position = Plate.transform.position;//set spawner position to plate position
        }
    }
}
