using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManager : MonoBehaviour {
	

	// Use this for initialization
	public GameObject QuestionText;
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
		Debug.Log("Fixed");
		if(point == 500){
			QuestionText.GetComponent<Text>().text = HardQuestionList[Random.Range(0,EasyQuestionList.Length)].QuestionText;
		}
		if(point == -500){
			QuestionText.GetComponent<Text>().text = HardQuestionList[Random.Range(0,EasyQuestionList.Length)].QuestionText;
		}
		if(point == 250){
			QuestionText.GetComponent<Text>().text = MediumQuestionList[Random.Range(0,MediumQuestionList.Length)].QuestionText;
		}
		if(point == -250){
			QuestionText.GetComponent<Text>().text = MediumQuestionList[Random.Range(0,MediumQuestionList.Length)].QuestionText;
		}
		if(point == -5){
			QuestionText.GetComponent<Text>().text = MediumQuestionList[Random.Range(0,MediumQuestionList.Length)].QuestionText;
		}
		if(point == 100){
			QuestionText.GetComponent<Text>().text = EasyQuestionList[Random.Range(0,EasyQuestionList.Length)].QuestionText;
		}
		if(point == -150){
			QuestionText.GetComponent<Text>().text = EasyQuestionList[Random.Range(0,EasyQuestionList.Length)].QuestionText;
		}
		if(point == 0){
			QuestionText.GetComponent<Text>().text = UltimateQuestionList[Random.Range(0,UltimateQuestionList.Length)].QuestionText;
		}
	}
}
