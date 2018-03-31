using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    public GameObject obstacle;
    public float TimeTillObjectSpawn = 3;
    private float CurrentTimer;
	// Use this for initialization
	void Start () {
		CurrentTimer = TimeTillObjectSpawn;
	}
	
	// Update is called once per frame
	void Update () {
        CurrentTimer -= Time.deltaTime;
        if(CurrentTimer <= 0)
        {
            CurrentTimer = TimeTillObjectSpawn;
            Instantiate(obstacle, transform);
        }
	}
}
