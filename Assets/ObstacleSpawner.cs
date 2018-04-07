using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    public GameObject obstacle;
    public float MinSpawnTime = 3;
    public float MaxSpawnTime = 3;
    private float CurrentTimer;
	// Use this for initialization
	void Start () {
		CurrentTimer = MaxSpawnTime;
	}
	
	// Update is called once per frame
	void Update () {
        CurrentTimer -= Time.deltaTime;
        if(CurrentTimer <= 0)
        {
            CurrentTimer = Random.Range (MinSpawnTime, MaxSpawnTime);
            Instantiate(obstacle, transform);
        }
	}
}
