using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSineMove : MonoBehaviour {
    public Vector2 moveScale;
    public float sineInputMultiplier = 1;
    private Rigidbody2D rigidbody;
    private float initialTime;
	// Use this for initialization
	void Awake () {
        rigidbody = GetComponent<Rigidbody2D>();
        initialTime = Time.timeSinceLevelLoad ;
	}
	
	// Update is called once per frame
	void Update () {
        var sineX = Time.timeSinceLevelLoad - initialTime;
        rigidbody.velocity = new Vector2(moveScale.x, moveScale.y * Mathf.Sin(sineX * sineInputMultiplier));

	}
}
