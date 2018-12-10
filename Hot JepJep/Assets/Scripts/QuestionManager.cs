using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class QuestionManager : MonoBehaviour {


	// Use this for initialization
	public bool Active;
	public int Try;
	public GameObject CorrectSound;
	public GameObject WrongSound;
	public GameObject Dice;
	public GameObject Scoreboard;
	public GameObject QuestionText;
	public GameObject QuestionImage;
	public GameObject StatusText;
	public GameObject StealMenu;
	public GameObject StealSlider;
	public GameObject SwapMenu;
	public GameObject SwapSlider;
	public GameObject[] AnswerChoices;
	public Question[] EasyQuestionList;
	public Question[] MediumQuestionList;
	public Question[] HardQuestionList;
	public Question[] UltimateQuestionList;

	public string CorrectAnswerString;
	Question[] EasyQuestionListUsed;
	Question[] MediumQuestionListUsed;
	Question[] HardQuestionListUsed;
	Question[] UltimateQuestionListUsed;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void showQuestion(int point){
		Active = true;
		Try = 1;
		QuestionImage.SetActive(false);
		//Debug.Log("Fixed");
		if(point == 500){
			int QuestionNumber = Random.Range(0,HardQuestionList.Length);
			QuestionText.GetComponent<Text>().text = HardQuestionList[QuestionNumber].QuestionText;
			if(HardQuestionList[QuestionNumber].QuestionImage != null){
				QuestionImage.GetComponent<Image>().sprite = HardQuestionList[QuestionNumber].QuestionImage;
				QuestionText.GetComponent<Text>().text = "";
				QuestionImage.SetActive(true);
			}
			showAnswerChoices(HardQuestionList[QuestionNumber]);
		}
		if(point == 250){
			int QuestionNumber = Random.Range(0,MediumQuestionList.Length);
			QuestionText.GetComponent<Text>().text = MediumQuestionList[QuestionNumber].QuestionText;
			if(MediumQuestionList[QuestionNumber].QuestionImage != null){
				QuestionImage.GetComponent<Image>().sprite = MediumQuestionList[QuestionNumber].QuestionImage;
				QuestionText.GetComponent<Text>().text = "";
				QuestionImage.SetActive(true);
			}
			showAnswerChoices(MediumQuestionList[QuestionNumber]);
		}
		if(point == -250){
			Debug.Log("h");
			int QuestionNumber = Random.Range(0,MediumQuestionList.Length);
			QuestionText.GetComponent<Text>().text = MediumQuestionList[QuestionNumber].QuestionText;
			if(MediumQuestionList[QuestionNumber].QuestionImage != null){
				QuestionImage.GetComponent<Image>().sprite = MediumQuestionList[QuestionNumber].QuestionImage;
				QuestionText.GetComponent<Text>().text = "";
				QuestionImage.SetActive(true);
			}
			showAnswerChoices(MediumQuestionList[QuestionNumber]);
		}
		if(point == -5){
			int QuestionNumber = Random.Range(0,MediumQuestionList.Length);
			QuestionText.GetComponent<Text>().text = MediumQuestionList[QuestionNumber].QuestionText;
			if(MediumQuestionList[QuestionNumber].QuestionImage != null){
				QuestionImage.GetComponent<Image>().sprite = MediumQuestionList[QuestionNumber].QuestionImage;
				QuestionText.GetComponent<Text>().text = "";
				QuestionImage.SetActive(true);
			}
			showAnswerChoices(MediumQuestionList[QuestionNumber]);
		}
		if(point == 100){
			int QuestionNumber = Random.Range(0,EasyQuestionList.Length);
			QuestionText.GetComponent<Text>().text = EasyQuestionList[QuestionNumber].QuestionText;
			if(EasyQuestionList[QuestionNumber].QuestionImage != null){
				QuestionImage.GetComponent<Image>().sprite = EasyQuestionList[QuestionNumber].QuestionImage;
				QuestionText.GetComponent<Text>().text = "";
				QuestionImage.SetActive(true);
			}
			showAnswerChoices(EasyQuestionList[QuestionNumber]);
		}
		if(point == -150){
			int QuestionNumber = Random.Range(0,EasyQuestionList.Length);
			QuestionText.GetComponent<Text>().text = EasyQuestionList[QuestionNumber].QuestionText;
			if(EasyQuestionList[QuestionNumber].QuestionImage != null){
				QuestionImage.GetComponent<Image>().sprite = EasyQuestionList[QuestionNumber].QuestionImage;
				QuestionText.GetComponent<Text>().text = "";
				QuestionImage.SetActive(true);
			}
			showAnswerChoices(EasyQuestionList[QuestionNumber]);
		}
		if(point == 0){
			int QuestionNumber = Random.Range(0,UltimateQuestionList.Length);
			QuestionText.GetComponent<Text>().text = UltimateQuestionList[QuestionNumber].QuestionText;
			if(UltimateQuestionList[QuestionNumber].QuestionImage != null){
				QuestionImage.GetComponent<Image>().sprite = UltimateQuestionList[QuestionNumber].QuestionImage;
				QuestionText.GetComponent<Text>().text = "";
				QuestionImage.SetActive(true);
			}
			showAnswerChoices(UltimateQuestionList[QuestionNumber]);
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

	public void showAnswerChoices(Question currentQuestion){
		CorrectSound.SetActive(false);
		WrongSound.SetActive(false);
		ShuffleArray(AnswerChoices);
		CorrectAnswerString = currentQuestion.CorrectAnswer;
		//Debug.Log(AnswerChoices.Length);
		// Debug.Log(currentQuestion.AnswerChoices.Length);
		for(int i=0;i<currentQuestion.AnswerChoices.Length;i++){
			AnswerChoices[i].transform.GetChild(0).GetComponent<Text>().text = currentQuestion.AnswerChoices[i];
		}
		AnswerChoices[3].transform.GetChild(0).GetComponent<Text>().text = currentQuestion.CorrectAnswer;
	}
	public void showText(string text,bool red){
		if(red){
			StatusText.GetComponent<Image>().GetComponent<Image>().color = new Color(1f,0.0518868f,0.1366344f);
			StatusText.transform.GetChild(0).GetComponent<Text>().color = new Color(1f,0.0518868f,0.1366344f);
		}
		else{
			StatusText.GetComponent<Image>().GetComponent<Image>().color = new Color(0.05098039f,1f,0.2566013f);
			StatusText.transform.GetChild(0).GetComponent<Text>().color = new Color(0.05098039f,1f,0.2566013f);
		}
		StatusText.transform.GetChild(0).GetComponent<Text>().text = text;
		StatusText.SetActive(true);
		StartCoroutine(showStatusText());
	}
	IEnumerator showStatusText(){
		yield return new WaitForSeconds(2f);
		StatusText.SetActive(false);
	}

	public void checkAnswer(){
		CorrectSound.SetActive(false);
		WrongSound.SetActive(false);
		if(EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text == CorrectAnswerString){
			showText("Correct",false);
			if(Try == 2){
				CorrectSound.SetActive(true);
				if(Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]>0){
					Scoreboard.GetComponent<Scoreboard>().Scores[Dice.GetComponent<Dice>().CurrentTurn-1] += (Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]/2);
					Dice.GetComponent<Dice>().nextTurn();
				}
				else if(Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll] == 0){
					for(int i = 0;i<Scoreboard.GetComponent<Scoreboard>().Scores.Length;i++){
						if(i != Dice.GetComponent<Dice>().CurrentTurn-1 && Scoreboard.GetComponent<Scoreboard>().Scores[i] > 0){
							Scoreboard.GetComponent<Scoreboard>().Scores[i] = 0;
							Dice.GetComponent<Dice>().nextTurn();
						}
					}
				}
				else if(Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll] == -5){
					Dice.GetComponent<Dice>().hideQuestionPanel();
					SwapMenu.SetActive(true);
				}
				else{
					Dice.GetComponent<Dice>().hideQuestionPanel();
					StealMenu.SetActive(true);
				}
			}
			else{
				CorrectSound.SetActive(true);
				if(Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]>0){
					Scoreboard.GetComponent<Scoreboard>().Scores[Dice.GetComponent<Dice>().CurrentTurn-1] += (Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]);
					Dice.GetComponent<Dice>().nextTurn();
				}
				else if(Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll] == 0){
					for(int i = 0;i<Scoreboard.GetComponent<Scoreboard>().Scores.Length;i++){
						if(i != Dice.GetComponent<Dice>().CurrentTurn-1 && Scoreboard.GetComponent<Scoreboard>().Scores[i] > 0){
							Scoreboard.GetComponent<Scoreboard>().Scores[i] = 0;
							Dice.GetComponent<Dice>().nextTurn();
						}
					}
				}
				else if(Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll] == -5){
					Dice.GetComponent<Dice>().hideQuestionPanel();
					SwapMenu.SetActive(true);
				}
				else{
					Dice.GetComponent<Dice>().hideQuestionPanel();
					StealMenu.SetActive(true);
				}
			}
		}
		else{
			showText("Incorrect",true);
			if(Try == 1){
				WrongSound.SetActive(true);
				Dice.GetComponent<Dice>().nextStealTurn();
				Try += 1;
			}
			else{
				WrongSound.SetActive(true);
				Try = 1;
				Dice.GetComponent<Dice>().nextTurn();
			}
		}
	}

	public void stealPoints(){
		if(Try == 2){
			Scoreboard.GetComponent<Scoreboard>().Scores[Dice.GetComponent<Dice>().CurrentTurn-1] -= (Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]/2);
			Scoreboard.GetComponent<Scoreboard>().Scores[(int)StealSlider.GetComponent<Slider>().value-1] += (Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]/2);
			Dice.GetComponent<Dice>().nextTurn();
			StealMenu.SetActive(false);
		}
		else{
			Scoreboard.GetComponent<Scoreboard>().Scores[Dice.GetComponent<Dice>().CurrentTurn-1] -= (Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]);
			Scoreboard.GetComponent<Scoreboard>().Scores[(int)StealSlider.GetComponent<Slider>().value-1] += (Dice.GetComponent<Dice>().DiceStuff[Dice.GetComponent<Dice>().finalRoll]);
			Dice.GetComponent<Dice>().nextTurn();
			StealMenu.SetActive(false);
		}
	}

	public void swapPoints(){
		Debug.Log(Dice.GetComponent<Dice>().CurrentTurn-1);
		Debug.Log((int)StealSlider.GetComponent<Slider>().value-1);
		int oldCurrentScore;
		int oldOtherScore;
		oldCurrentScore = Scoreboard.GetComponent<Scoreboard>().Scores[Dice.GetComponent<Dice>().CurrentTurn-1];
		oldOtherScore = Scoreboard.GetComponent<Scoreboard>().Scores[(int)SwapSlider.GetComponent<Slider>().value-1];

		Scoreboard.GetComponent<Scoreboard>().Scores[Dice.GetComponent<Dice>().CurrentTurn-1] = oldOtherScore;
		Scoreboard.GetComponent<Scoreboard>().Scores[(int)SwapSlider.GetComponent<Slider>().value-1] = oldCurrentScore;
		Dice.GetComponent<Dice>().nextTurn();
		SwapMenu.SetActive(false);
	}
}
