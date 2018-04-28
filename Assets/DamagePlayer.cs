using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    public Vector2 Knockback = new Vector2(-10, 10);
    public float Damage = 1;
    public bool DieOnHit = true;

	// Use this for initialization
	void Start () {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {      
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Health>().Hurt(Damage);
            if (DieOnHit) Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
