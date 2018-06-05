using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes_Button : MonoBehaviour {


    public void OnMouseUp()
    {
        SceneManager.LoadScene("Infinite");
    }
}
