using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	
	int maxGuessesAllowed = 5;
	
	int max = 1000;
	int min = 1;
	int guess = 500;	
	
	public Text text;
	
	void Start () {
		StartGame ();
		
	}
	
	void StartGame () {
	
		max = 1000;
		min = 1;
		guess = 500;
		NextGuess();
		
	}
	
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	public void NextGuess ()
	{
		
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		
		maxGuessesAllowed = maxGuessesAllowed - 1;
		
		if (maxGuessesAllowed <= 0)
		{
		
		
		Application.LoadLevel("Start Scene");
		}
	}
	
}
