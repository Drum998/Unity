using UnityEngine;
using System.Collections;


public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	
	// Use this for initialization
	void Start () {
		max = max + 1;
		print ("Welcome to Number Wizard");
		print ("Pick a Number");
		

		
		print ("From " + min + " to " + max);
		
		print ("Is the number higher or lower than " + guess);
		
		print ("Up = higher. Down = lower. Return = equal.");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			//print ("Up arrow");
			min = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
		}else if (Input.GetKeyDown (KeyCode.DownArrow)){
			//print ("Down arrow");
			max = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
		}else if (Input.GetKeyDown (KeyCode.Return)){
			print ("I won!");
		}
	}
}
