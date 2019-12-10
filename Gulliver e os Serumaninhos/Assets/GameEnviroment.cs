using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnviroment : MonoBehaviour {

    public Animator lightAnimator;

    public Animation lightAnimation;

    public float dayLightTime;

    public GulliverStatus player;

    private void Start() {
        lightAnimator.speed = 0f;
    }

    void FixedUpdate () {

        dayLightTime = player.energyKeeped;

        lightAnimator.Play("HighNoon",0, (1f/100)*dayLightTime);
        
	}
}
