using UnityEngine;
using System.Collections;


public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame ();
		
	}

		// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			min = guess;
			NextGuess ();
		}else if (Input.GetKeyDown (KeyCode.DownArrow)){
			max = guess;
			NextGuess ();
		}else if (Input.GetKeyDown (KeyCode.Return)){
			print ("I won!");
			min = 1;
			max = 1000;
			guess = 500;
			StartGame ();
		}
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a Number");
		print ("From " + min + " to " + (max - 1));
		print ("Is the number higher or lower than " + guess);
		print ("Up = higher. Down = lower. Return = equal.");	
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up = higher. Down = lower. Return = equal.");
	}
}
