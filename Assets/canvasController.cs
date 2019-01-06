
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class canvasController : MonoBehaviour {

	public GameObject scoreText;
	int score;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.GetComponent<Text>().text = "Score: 0";
		
	}
	
	// Update is called once per frame
	void Update () {
		//This code is temporary
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseScore(5);
        }
        //End of Temporary Code

	}

	public void IncreaseScore(int amount)
	{
		//Increase score by amount
		score += amount;

		scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
	}

}










