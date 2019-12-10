using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Command : MonoBehaviour {

    public GameObject AButtonCanvas, DButtonCanvas;

    public float intervalLeftB, intervalRightB, looseAmount, amountLoose;

    public Texture2D AButton, AButtonPressed, DButton, DButtonPressed;

    public int PressTime;

    public bool getLeft, getRight, timeToPressShake;

    private bool lastPressedIsLeft;

    private float timeRemaining;

    public GameObject player;

   // Use this for initialization
   void Start () {

        timeRemaining = PressTime;
        amountLoose = 0;
        player.GetComponent<Animator>().SetFloat("Direction", 0.5f);
        timeToPressShake = true;
    }

	// Update is called once per frame
	void Update () {

        GetInterval(PressTime);

        if (timeToPressShake) {
            AButtonCanvas.SetActive(true);
            DButtonCanvas.SetActive(true);
        } else {
            AButtonCanvas.SetActive(false);
            DButtonCanvas.SetActive(false);
        }

    }

    void GetInterval(int PressTime) {

        player.GetComponent<Animator>().SetFloat("Direction", 0.5f);
        if (timeToPressShake){

            getLeft = Input.GetButtonDown("ShakeLeft");
            getRight = Input.GetButtonDown("ShakeRight");

            timeRemaining -= Time.deltaTime;

            if(timeRemaining <= 0) {
                timeToPressShake = false;
                timeRemaining = PressTime;
                Debug.Log("A corda está um pouco mais folgada, desse tanto: "+ amountLoose);
            }

            if (getLeft & lastPressedIsLeft== false) {
                GulliverStatus.instance.ShakingEnergy(2);
                LooseTie(1);
                player.GetComponent<Animator>().SetFloat("Direction", 0);
                lastPressedIsLeft = true;
                AButtonCanvas.GetComponent<RawImage>().texture = AButtonPressed;
            } else {
                AButtonCanvas.GetComponent<RawImage>().texture = AButton;
            }

            if (getRight & lastPressedIsLeft == true) {
                player.GetComponent<Animator>().SetFloat("Direction", 1);
                lastPressedIsLeft = false;
                DButtonCanvas.GetComponent<RawImage>().texture = DButtonPressed;
            } else {
                DButtonCanvas.GetComponent<RawImage>().texture = DButton;
            }
        }        
    }

    void LooseTie(float amountLoose) {
        AmarraStatus[] objList;

        objList = FindObjectsOfType<AmarraStatus>() ;

        for (int i = 0; i < objList.Length; i++) {

            objList[i].LooseTiesShaking(amountLoose);
        }


    }
}
