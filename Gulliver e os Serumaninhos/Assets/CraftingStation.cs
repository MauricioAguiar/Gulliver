using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public struct ItemAmount {

    public Item item;
    public int amount;
}

[CreateAssetMenu]
public class CraftingStation :ScriptableObject {


    public List<ItemAmount> Materials;
    public List<ItemAmount> Results;

    // Use this for initialization
    void Start() {


    }
    // Update is called once per frame
    void Update() {

    }
}
