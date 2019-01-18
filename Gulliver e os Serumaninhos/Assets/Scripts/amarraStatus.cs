using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amarraStatus : MonoBehaviour {

    public float resistence;

    public enum Material{rope,tape,chain};

    public enum Instrument { Knife, Scissors, chain };

    public Material selectedMaterial;

    public bool cuttedByKnife, cuttedByScissors;

	// Use this for initialization
	void Start () {	

	}
	
	// Update is called once per frame
	void Update () {
		if (resistence <= 0) {
            Destroy(gameObject);
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
