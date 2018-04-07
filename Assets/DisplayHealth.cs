using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHealth : MonoBehaviour {
    public GameObject character;
    public float MaxScale = 10;
    private Health health;


	// Use this for initialization
	void Start () {
       health = character.GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.localScale = new Vector3((health.CurrentHealth / health.MaxHealth) * MaxScale, this.transform.localScale.y, 1);
	}
}
