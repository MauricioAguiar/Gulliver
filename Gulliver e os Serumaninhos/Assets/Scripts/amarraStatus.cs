using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmarraStatus : MonoBehaviour {

    public float resistence;

    public enum Material{Corda,Fita,Corrente};

    public enum Instrument { Knife, Scissors, chain };

    public Material selectedMaterial;

    public bool cuttedByKnife, cuttedByScissors;


	// Update is called once per frame
	void Update () {
		if (resistence <= 0) {
            Destroy(gameObject);
        }
	}

    public void LooseTiesShaking(float amount) {
        if(resistence <= 25) {
            Debug.Log("Acho que não folga mais que isso preciso arrumar outro jeito");
        } else {
            resistence -= amount;
        }
    }

    public void LooseTies(float amount) {

        resistence -= amount;
    }

    void DoDamage() {   

    }

    private void OnDestroy() {
        //animation.setBool("");
    }


}
