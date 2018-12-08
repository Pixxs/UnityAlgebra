using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {
	public int[] Scores;
	public GameObject Score1TextObject;
	public GameObject Score2TextObject;
	public GameObject Score3TextObject;
	public GameObject Score4TextObject;
	public GameObject Score5TextObject;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Score1TextObject.GetComponent<Text>().text = Scores[0].ToString();
		Score2TextObject.GetComponent<Text>().text = Scores[1].ToString();
		Score3TextObject.GetComponent<Text>().text = Scores[2].ToString();
		Score4TextObject.GetComponent<Text>().text = Scores[3].ToString();
		Score5TextObject.GetComponent<Text>().text = Scores[4].ToString();
	}
}
