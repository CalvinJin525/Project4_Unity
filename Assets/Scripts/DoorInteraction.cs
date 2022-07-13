using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace com
{
    namespace interiorlighting
    {
        namespace interactable
        {
            public class DoorInteraction : MonoBehaviour
            {
                private bool doorIsOpen = false;
                private float doorOpenedTime = 0.0f;
                public AudioSource audioSource;
                
                // Start is called before the first frame update
                void Start()
                {
                    audioSource = GetComponent<AudioSource>();
                }

                // Update is called once per frame
                void Update()
                {
                    if (doorIsOpen && doorOpenedTime > 3.0)
                    {
                        doorIsOpen = false;
                        GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
                        audioSource.Play();
                    }
                    doorOpenedTime += Time.deltaTime;
                }

                public void OpenDoor()
                {
                    doorIsOpen = true;
                    doorOpenedTime = 0.0f;
                    GetComponent<Transform>().rotation = Quaternion.Euler(0, 90, 0);
                    audioSource.Play();
                    
                }

            }

        }
    }
}
