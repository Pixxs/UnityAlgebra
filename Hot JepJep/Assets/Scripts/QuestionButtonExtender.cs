using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionButtonExtender : MonoBehaviour {
	public string c1Question1;
	public string c1Question2;
	public string c1Question3;
	public string c1Question4;
	public string c1Question5;
	public string c2Question1;
	public string c2Question2;
	public string c2Question3;
	public string c2Question4;
	public string c2Question5;
	public string c3Question1;
	public string c3Question2;
	public string c3Question3;
	public string c3Question4;
	public string c3Question5;
	public string c4Question1;
	public string c4Question2;
	public string c4Question3;
	public string c4Question4;
	public string c4Question5;

	public Text QuestionWords;

	public GameObject Ui1;
	public GameObject Ui2;



	void Start () {

	}

	void Update () {

	}
	public void Q1 () {
		Ui1.SetActive(false);
		Ui2.SetActive(true);
		QuestionWords.text = c1Question1;
	}
}
