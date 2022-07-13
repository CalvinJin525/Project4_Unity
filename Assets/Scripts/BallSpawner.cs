using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneDynamism
{
    public class BallSpawner : MonoBehaviour
    {        
        private int totalBallsSpawned = 0;
        public int maxBallsCount = 50;
        public GameObject ballToSpawn;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(!ballToSpawn || totalBallsSpawned > maxBallsCount){
                return;
            }
            float x = Random.Range(126.0f, 130.0f);
            float y = 30.0f;
            float z = Random.Range(219.0f, 250.0f);

            GameObject spawned = Instantiate<GameObject>(ballToSpawn);
            spawned.GetComponent<Transform>().position = new Vector3(x, y, z);
            totalBallsSpawned ++;
        }
    }
}