using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomItem : MonoBehaviour {


    public GameObject[] item;


    void PickItem() {

        Vector2 aux = new Vector2(0.26f, -0.28f);
        Instantiate(item[Random.Range(0, item.Length)], aux, Quaternion.identity);

    }
}
