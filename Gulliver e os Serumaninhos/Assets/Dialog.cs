using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour {

    public Text textDisplay;
    public string[] sentences;
    public float typingSpeed;

    public GameObject ContinueButton;

    private int index;


    private void Update() {
        
        if(textDisplay.text == sentences[index]) {
            ContinueButton.SetActive(true);
        }
    }

    private void Start() {
        StartCoroutine(Type());
    }


	IEnumerator Type() {

        foreach(char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(4f);
        }


    }

    public void NextSentence() {

        ContinueButton.SetActive(false);

        if (index < sentences.Length - 1) {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else {
            textDisplay.text = "";
            ContinueButton.SetActive(false);
        }
    }


}
