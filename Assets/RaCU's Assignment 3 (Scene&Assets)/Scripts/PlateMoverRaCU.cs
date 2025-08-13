using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace RaCU
{
    public class PlateMoverRaCU : MonoBehaviour
    {
        public GameObject spawner;
        public UnityEvent goButtonPressed;

        public void buttonPressed()
        {
            StartCoroutine(movePlate());
            goButtonPressed.Invoke();
        }

        public IEnumerator movePlate()
        {
            Vector3 platePosition = transform.position + Vector3.down * 5f; //vector3 defining how the plate will move down
            transform.position = platePosition; //applies vector3 to plate's transform position, plate moves
            yield return null;
            Debug.Log("Coroutine started");
            
        }
    }
}
