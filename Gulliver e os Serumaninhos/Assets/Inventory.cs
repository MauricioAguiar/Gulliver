using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public GameObject inventory, slotHolder, itemManager;

    private GameObject itemPickedUp;

    private int amountOfSlots;

    private Transform[] slot;
    private Texture iconItem;

    public bool itemAdded;

    private bool inventoryEnabled;

    // Use this for initialization
    void Start () {

        amountOfSlots = slotHolder.transform.childCount;

        slot = new Transform[amountOfSlots]; 

        GetSizeSlots();
        itemAdded = false;
	}

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            inventoryEnabled = !inventoryEnabled;
        }
        if (inventoryEnabled){
            inventory.GetComponent<Canvas>().enabled = true;
        } else{
            inventory.GetComponent<Canvas>().enabled = false;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Item") {
            itemPickedUp = collision.gameObject;
            AddItem(itemPickedUp);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.tag== "Item") {
            itemAdded = false;
        }
    }


    public void AddItem(GameObject item) {

        for (int i = 0; i < amountOfSlots; i++) {
            if (slot[i].GetComponent<Slot>().empty && itemAdded == false) {
                itemAdded = true;

                slot[i].GetComponent<Slot>().item = itemPickedUp;
                slot[i].GetComponent<Slot>().itemIcon = itemPickedUp.GetComponent<Item>().itemIcon;

                item.transform.parent = itemManager.transform;

                Destroy(item.GetComponent<SpriteRenderer>()) ;
            }
        }
    }

    public void GetSizeSlots() {

        for (int i = 0; i < amountOfSlots; i++) {

            slot[i] = slotHolder.transform.GetChild(i);
        }
    }
}
