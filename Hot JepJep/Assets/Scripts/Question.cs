using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class Question{
		public string QuestionText;
		public Image QuestionImage;
		public string CorrectAnswer;
		public Image CorrectAnswerImage;
		public string[] AnswerChoices;
		public Image[] AnswerChoicesImages;
		public Question(string qtext, Image qimage, string ans, Image ansImage,string[] ansChoices, Image[] ansChoiceImages){
			QuestionText = qtext;
			QuestionImage = qimage;
			CorrectAnswer = ans;
			AnswerChoices = ansChoices;
			AnswerChoicesImages = ansChoiceImages;
			CorrectAnswerImage = ansImage;
		}
}