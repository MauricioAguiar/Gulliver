using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour {

    public float intervalLeftB, intervalRightB, looseAmount, amountLoose;

    public int PressTime;

    public bool getLeft, getRight, timeToPressShake;

    private bool lastPressedIsLeft;

    private float timeRemaining;

    public GameObject player;

   // Use this for initialization
   void Start () {
        timeRemaining = PressTime;
        amountLoose = 0;
    }

	// Update is called once per frame
	void Update () {

        GetInterval(PressTime);
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
                LooseTie(amountLoose);
                amountLoose = 0;
            }

            if (getLeft & lastPressedIsLeft== false) {
                amountLoose += 1;
                
                player.GetComponent<Animator>().SetFloat("Direction", 0);
                lastPressedIsLeft = true;

            }if (getRight & lastPressedIsLeft == true) {
                player.GetComponent<Animator>().SetFloat("Direction", 1);
                lastPressedIsLeft = false;
            } 
        }        
    }

    void LooseTie(float amountLoose) {
        amarraStatus[] objList;

        objList = FindObjectsOfType<amarraStatus>() ;

        for (int i = 0; i < objList.Length; i++) {

            objList[i].LooseTies(amountLoose);
        }


    }
}
