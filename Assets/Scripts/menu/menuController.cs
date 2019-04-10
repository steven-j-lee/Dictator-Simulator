using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {

	// Use this for initialization
	// Update is called once per frame
	
    public void startGame()
    {

        SceneManager.LoadScene(1);
    }
}
