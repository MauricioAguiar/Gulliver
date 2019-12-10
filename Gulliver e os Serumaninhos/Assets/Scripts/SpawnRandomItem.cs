using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomItem : MonoBehaviour {


    public GameObject[] item;


    private void Start() {
        InvokeRepeating("PickItem", 0, 30f);
    }


   void PickItem() {

        Instantiate(item[Random.Range(0, item.Length)], transform.position, Quaternion.identity);

    }
}
