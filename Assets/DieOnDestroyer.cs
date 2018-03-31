using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.name == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
