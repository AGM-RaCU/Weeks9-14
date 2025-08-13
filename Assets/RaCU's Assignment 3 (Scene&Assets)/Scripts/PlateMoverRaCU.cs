using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace RaCU
{
    public class PlateMoverRaCU : MonoBehaviour
    {
        public GameObject spawner; //spawner gameobject
        public UnityEvent goButtonPressed; //event for button press

        public void buttonPressed() //method for button press
        {
            StartCoroutine(movePlate());//start coroutine
            goButtonPressed.Invoke();//call event
        }

        public IEnumerator movePlate() //coroutine to move plate
        {
            Vector3 platePosition = transform.position + Vector3.down * 5f; //vector3 defining how the plate will move down
            transform.position = platePosition; //applies vector3 to plate's transform position, plate moves
            yield return null; //end coroutine
            
        }
    }
}
