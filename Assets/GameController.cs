using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


    public static GameController instance;
    public Text ScoreText { get; set; }
    public GameObject gameOverText;

    public bool gameOver = false;
    
    // Use this for initialization
	void Awake ()
    {
		if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void PlayerDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
