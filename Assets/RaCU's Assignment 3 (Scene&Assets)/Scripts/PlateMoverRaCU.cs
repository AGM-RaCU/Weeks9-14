using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace RaCU
{
    public class PlateMoverRaCU : MonoBehaviour
    {
        public GameObject spawner;
        public GameObject plate;
        public UnityEvent goButtonPressed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void buttonPressed()
        {
            StartCoroutine(movePlate());
            goButtonPressed.Invoke();
        }

        public IEnumerator movePlate()
        {
            Vector3 platePosition = plate.transform.position + Vector3.down * Time.deltaTime; //vector3 defining how the plate will move down
            plate.transform.position = platePosition; //applies vector3 to plate's transform position, plate moves
            
            Debug.Log("Coroutine started");
            yield return null;
        }
    }
}
