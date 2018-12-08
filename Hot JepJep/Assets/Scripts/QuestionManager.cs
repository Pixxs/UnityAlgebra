using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManager : MonoBehaviour {
	

	// Use this for initialization
	public GameObject QuestionText;
	public GameObject[] AnswerChoices;
	public Question[] EasyQuestionList;
	public Question[] MediumQuestionList;
	public Question[] HardQuestionList;
	public Question[] UltimateQuestionList;

	Question[] EasyQuestionListUsed;
	Question[] MediumQuestionListUsed;
	Question[] HardQuestionListUsed;
	Question[] UltimateQuestionListUsed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showQuestion(int point, int team){
		//Debug.Log("Fixed");
		if(point == 500){
			int QuestionNumber = Random.Range(0,HardQuestionList.Length);
			QuestionText.GetComponent<Text>().text = HardQuestionList[QuestionNumber].QuestionText;
			showAnswerChoices(HardQuestionList[QuestionNumber]);
		}
		if(point == -500){
			int QuestionNumber = Random.Range(0,EasyQuestionList.Length);
			QuestionText.GetComponent<Text>().text = HardQuestionList[QuestionNumber].QuestionText;
			showAnswerChoices(HardQuestionList[QuestionNumber]);
		}
		if(point == 250){
			int QuestionNumber = Random.Range(0,MediumQuestionList.Length);
			QuestionText.GetComponent<Text>().text = MediumQuestionList[QuestionNumber].QuestionText;
			showAnswerChoices(MediumQuestionList[QuestionNumber]);
		}
		if(point == -250){
			int QuestionNumber = Random.Range(0,MediumQuestionList.Length);
			QuestionText.GetComponent<Text>().text = MediumQuestionList[QuestionNumber].QuestionText;
			showAnswerChoices(MediumQuestionList[QuestionNumber]);
		}
		if(point == -5){
			int QuestionNumber = Random.Range(0,MediumQuestionList.Length);
			QuestionText.GetComponent<Text>().text = MediumQuestionList[QuestionNumber].QuestionText;
			showAnswerChoices(MediumQuestionList[QuestionNumber]);
		}
		if(point == 100){
			int QuestionNumber = Random.Range(0,EasyQuestionList.Length);
			QuestionText.GetComponent<Text>().text = EasyQuestionList[QuestionNumber].QuestionText;
			showAnswerChoices(EasyQuestionList[QuestionNumber]);
		}
		if(point == -150){
			int QuestionNumber = Random.Range(0,EasyQuestionList.Length);
			QuestionText.GetComponent<Text>().text = EasyQuestionList[QuestionNumber].QuestionText;
			showAnswerChoices(EasyQuestionList[QuestionNumber]);
		}
		if(point == 0){
			int QuestionNumber = Random.Range(0,UltimateQuestionList.Length);
			QuestionText.GetComponent<Text>().text = UltimateQuestionList[QuestionNumber].QuestionText;
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
		ShuffleArray(AnswerChoices);
		//Debug.Log(AnswerChoices.Length);
		// Debug.Log(currentQuestion.AnswerChoices.Length);
		for(int i=0;i<currentQuestion.AnswerChoices.Length;i++){
			AnswerChoices[i].transform.GetChild(0).GetComponent<Text>().text = currentQuestion.AnswerChoices[i];
		}
		AnswerChoices[3].transform.GetChild(0).GetComponent<Text>().text = currentQuestion.CorrectAnswer;
	}
}
