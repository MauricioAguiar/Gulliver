using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GulliverStatus : MonoBehaviour {

    public int energy;

    public List<Item> inventory;



	// Use this for initialization
	void Start () {
		
	}



    void DoAction() {

        if(energy <= 0) {
            energy = 0;
            Debug.Log("Estou muito cansado pra fazer alguma coisa acho melhor ir dormir");
        } else {
            energy -= 1;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
