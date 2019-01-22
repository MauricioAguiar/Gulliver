using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CraftableItem :MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {


    public GameObject result;

    public int requiredItems;

    public GameObject[] Item;

    private bool hovered;

    private GameObject player;

    public GameObject itemManager;

    // Use this for initialization
    void Start() {

        player = GameObject.FindGameObjectWithTag("Player");
        itemManager = GameObject.FindGameObjectWithTag("ItemManager");
    }

    // Update is called once per frame
    void Update() {


        if (hovered) {
            if (Input.GetMouseButtonDown(0)) {
                CheckForRequiredItems();
            }

        }
    }

    private void CheckForRequiredItems() {
        int itemsManager = itemManager.transform.childCount;

        if (itemsManager > 0) {

            int itemsFound = 0;

            for (int i = 0; i < itemsManager; i++) {

                for (int z = 0; z < requiredItems; z++) {

                    if (itemManager.transform.GetChild(i).GetComponent<Item>().itemType == Item[z].GetComponent<Item>().itemType) {
                        print("Item found");
                        itemsFound++;
                        break;
                    }
                }
            }
        if (itemsFound >= requiredItems) {

                player.GetComponent<Inventory>().AddItem(result); 
                print("All Items are found");
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData) {
        hovered = true;

    }

    public void OnPointerExit(PointerEventData eventData) {
        hovered = false;
    }

    public void OnPointerClick(PointerEventData eventData) {

    }
}
