using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {
	public GameObject DiceUIPanel;
	public GameObject DiceText;
	public int CurrentTurn = 1;
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
		if(Active){
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
				}
			}
		}
	}
}
