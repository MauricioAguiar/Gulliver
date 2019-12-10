using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GulliverStatus :MonoBehaviour {


    public Transform energyBar;
    public Slider energyAmount;

    public int energy;

    public int energyKeeped;
    private GameObject commands;

    public static GulliverStatus instance;

    //Instance method [Singleton]
    void ToInstance() {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this) {
            Destroy(this);
        }
    }

    // Use this for initialization
    void Start() {

        ToInstance();

        energyKeeped = energy-1;

    }

    private void FixedUpdate() {
        energyAmount.value = energyKeeped;
    }


    public void CurrentEnergy(int amount) {
        energyKeeped -= amount;
        energyKeeped = Mathf.Clamp(energyKeeped, 0, energy);

        energyAmount.value = energyKeeped;
        if (energyKeeped <= 0) {
            Debug.Log("Estou muito cansado pra fazer alguma coisa acho melhor ir dormir");
        }
    }

    public void ShakingEnergy(int amount) {
        energyKeeped -= amount;
        energyKeeped = Mathf.Clamp(energyKeeped, 25, energy);

        energyAmount.value = energyKeeped;
        if (energyKeeped <= 0) {
            Debug.Log("Estou muito cansado pra fazer alguma coisa acho melhor ir dormir");
        }
    }

    void PegarItem() {
    }


    void Shake() {
    }

    void Dormir() {

    }
}
