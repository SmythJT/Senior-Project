using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeText : MonoBehaviour {
public TextAsset text;
float r = 0.2f, g = 0.3f, b = 0.7f, a = 0.6f;

    void Start()
    {
        text = gameobject.GetComponent<Text>();
        text.color = new Color(r, g, b, a);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
