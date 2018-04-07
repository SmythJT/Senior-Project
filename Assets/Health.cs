using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public float MaxHealth = 3;

    public float CurrentHealth { get; private set; }
	// Use this for initialization
	void Start () {
        CurrentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if(CurrentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
	}

    public void Hurt(float amount)
    {
        CurrentHealth -= amount;
    }
}
