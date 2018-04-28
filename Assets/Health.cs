using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Health : MonoBehaviour {
    public float MaxHealth = 3;

    public float CurrentHealth { get; private set; }
    public float InvincibilityTime = .5f;

    private float invincibilityTimer = 0;
    private Platformer2DUserControl userControl;
	// Use this for initialization
	void Start () {
        userControl = GetComponent<Platformer2DUserControl>();
        CurrentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (invincibilityTimer > 0)
            invincibilityTimer -= Time.deltaTime;
        else
            userControl.SetControl(true);
		if(CurrentHealth <= 0)
        {
          this.gameObject.SetActive (false);
        }
	}

    public void Hurt(float amount)
    {
        if(invincibilityTimer <= 0)
        {
            userControl.SetControl(false);
            invincibilityTimer = InvincibilityTime;
            CurrentHealth -= amount;
        }
    }
}
