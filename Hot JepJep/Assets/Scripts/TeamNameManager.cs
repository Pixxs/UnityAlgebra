using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeamNameManager : MonoBehaviour {

	public string Team1Name;
	public string Team2Name;
	public string Team3Name;
	public string Team4Name;
	public string Team5Name;
	public GameObject Team1;
	public GameObject Team2;
	public GameObject Team3;
	public GameObject Team4;
	public GameObject Team5;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Team1Name = Team1.GetComponent<InputField>().text;
		Team2Name = Team2.GetComponent<InputField>().text;
		Team3Name = Team3.GetComponent<InputField>().text;
		Team4Name = Team4.GetComponent<InputField>().text;
		Team5Name = Team5.GetComponent<InputField>().text;
	
		PlayerPrefs.SetString ("Team1NameSave", Team1Name);
		PlayerPrefs.SetString ("Team2NameSave", Team2Name);
		PlayerPrefs.SetString ("Team3NameSave", Team3Name);
		PlayerPrefs.SetString ("Team4NameSave", Team4Name);
		PlayerPrefs.SetString ("Team5NameSave", Team5Name);
	}
}
