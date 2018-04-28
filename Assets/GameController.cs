using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


    public static GameController instance;
    public Text ScoreText;
    public GameObject gameOverText;

    private float score = 0;
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
        if (!gameOver)
            score += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.R) && gameOver)
            SceneManager.LoadScene("Infinite");
        ScoreText.text = string.Format("Score: {0:#.00}",score);
	}
    
    public void PlayerDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
