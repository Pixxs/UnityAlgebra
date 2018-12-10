using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {
	public GameObject DiceUIPanel;
	public GameObject DiceText;
	public int CurrentTurn = 1;
	public GameObject Scoreboard;
	public GameObject CurrentTernObject;
	public GameObject QuestionManager;
	public GameObject QuestionPanel;
	public bool Active;
	public bool Rolling;
	public int currentRoll;
	public int finalRoll;
	public int iterations = 0;
	// Use this for initialization
	// points: 500 (2 times), 250(5 times), 100(5 times), steal 150 (3 times), steal 250(3 times), swap (3 times, the -5 value), bribe (1 times, ultimate value)
	public int[] DiceStuff;
	private int[] DiceArray;
	void Start () {
		DiceUIPanel.GetComponent<Image>().color = Color.HSVToRGB(0f, 0.7f, 1f);
		DiceArray = DiceStuff;
		ShuffleArray(DiceArray);
	}

	// Update is called once per frame
	void Update () {
		//383.9 ; 108.8 265 428 586.4 746.4
		if (CurrentTurn == 1){
			CurrentTernObject.transform.position = new Vector3(108.8f,383.9f,0f);
		}
		if (CurrentTurn == 2){
			CurrentTernObject.transform.position = new Vector3(265f,383.9f,0f);
		}
		if (CurrentTurn == 3){
			CurrentTernObject.transform.position = new Vector3(428f,383.9f,0f);
		}
		if (CurrentTurn == 4){
			CurrentTernObject.transform.position = new Vector3(586.4f,383.9f,0f);
		}
		if (CurrentTurn == 5){
			CurrentTernObject.transform.position = new Vector3(746.4f,383.9f,0f);
		}


		if(Active){
			QuestionPanel.SetActive(false);
			DiceText.transform.GetChild(0).gameObject.SetActive(true);
			var oldColor = DiceUIPanel.GetComponent<Image>().color;
			float newHue;
			float newJunk;
			Color.RGBToHSV(oldColor, out newHue, out newJunk, out newJunk);
			newHue = newHue + 0.0025f;
			DiceUIPanel.GetComponent<Image>().color = Color.HSVToRGB(newHue, 0.7f, 1f);
			if (Input.GetKeyDown("space") && Rolling == false)
			{
				iterations = 0;
				finalRoll = Random.Range(0,DiceArray.Length-1);
				Roll();
				Rolling = true;
			}
		}
		else if(QuestionManager.GetComponent<QuestionManager>().Active){
			QuestionPanel.SetActive(true);
			DiceText.transform.GetChild(0).gameObject.SetActive(false);
		}
	}
	public static void ShuffleArray<T>(T[] arr) {
		for (int i = arr.Length - 1; i > 0; i--) {
			int r = Random.Range(0, i);
			T tmp = arr[i];
			arr[i] = arr[r];
			arr[r] = tmp;
		}
 	}

	void Roll(){
		InvokeRepeating("showRoll",0.0f,0.125f);
	}
	void showRoll() {

		if(Rolling){
			if(currentRoll == DiceArray.Length-1){
				currentRoll = 0;
			}else{
				currentRoll = currentRoll + 1;
			}

			if(DiceArray[currentRoll] == -1){
				DiceText.GetComponent<Text>().text = "Steal 150";
			}
			else if(DiceArray[currentRoll] == -2){
				DiceText.GetComponent<Text>().text = "Steal 250";
			}
			else if(DiceArray[currentRoll] == -5){
				DiceText.GetComponent<Text>().text = "Swap";
			}
			else if(DiceArray[currentRoll] == -10){
				DiceText.GetComponent<Text>().text = "Lose 150";
			}
			else if(DiceArray[currentRoll] == -20){
				DiceText.GetComponent<Text>().text = "Lose 250";
			}
			else{
				DiceText.GetComponent<Text>().text = DiceArray[currentRoll].ToString();
			}

			if(currentRoll == finalRoll){
				iterations = iterations + 1;
				if(iterations == 2){
					Rolling = false;
					Active = false;
					Debug.Log("1");
					Debug.Log(DiceArray[currentRoll]);
					if(DiceArray[currentRoll] == 500){
						QuestionManager.GetComponent<QuestionManager>().showQuestion(500);
					}
					if(DiceArray[currentRoll] == 250){
						QuestionManager.GetComponent<QuestionManager>().showQuestion(250);
					}
					if(DiceArray[currentRoll] == -250){
						QuestionManager.GetComponent<QuestionManager>().showQuestion(-250);
					}
					if(DiceArray[currentRoll] == -5){
						QuestionManager.GetComponent<QuestionManager>().showQuestion(-5);
					}
					if(DiceArray[currentRoll] == 100){
						QuestionManager.GetComponent<QuestionManager>().showQuestion(100);
					}
					if(DiceArray[currentRoll] == -150){
						QuestionManager.GetComponent<QuestionManager>().showQuestion(-150);
					}
					if(DiceArray[currentRoll] == 0){
						QuestionManager.GetComponent<QuestionManager>().showText("HARD QUESTION",true);
						QuestionManager.GetComponent<QuestionManager>().showQuestion(0);
					}
					if(DiceArray[currentRoll] == -10){
						QuestionManager.GetComponent<QuestionManager>().showText("Lose 150 points",true);
						Scoreboard.GetComponent<Scoreboard>().Scores[CurrentTurn-1] -= 150;
						nextTurn();
					}
					if(DiceArray[currentRoll] == -20){
						QuestionManager.GetComponent<QuestionManager>().showText("Lose 250 points",true);
						Scoreboard.GetComponent<Scoreboard>().Scores[CurrentTurn-1] -= 250;
						nextTurn();
					}
				}
			}
		}
	}
	public void nextTurn(){
		if(CurrentTurn == 5){
			CurrentTurn = 1;
		}
		else{
			CurrentTurn += 1;
		}
		Active = true;
		QuestionPanel.SetActive(false);
	}
	public void hideQuestionPanel(){
		Debug.Log("nnn");
		QuestionPanel.SetActive(false);
	}
	public void nextStealTurn(){
		if(CurrentTurn == 5){
			CurrentTurn = 1;
		}
		else{
			CurrentTurn += 1;
		}
	}
}
