using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GulliverStatus : MonoBehaviour {

    public int energy;

    private int energyKeeped;
    private GameObject commands;

	// Use this for initialization
	void Start () {

        energyKeeped = energy;
       
	}


    void PegarItem() {
        DoAction();
    }


    void DoAction() {

        if(energy <= 0) {
            energy = 0;
            Debug.Log("Estou muito cansado pra fazer alguma coisa acho melhor ir dormir");
        } else {
            energy -= 1;
        }
    }

    void Shake() {
    }

    void CortarCorda() {
        DoAction();
    }

    void Dormir() {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
