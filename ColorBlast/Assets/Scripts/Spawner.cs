using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


    public GameObject Ball;
    public float delayTimer = 2.0f;
    float timer;

    

	// Use this for initialization
	void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Vector3 ballPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            Instantiate(Ball, ballPosition, transform.rotation);
            timer = delayTimer;
        }   
    }
}
