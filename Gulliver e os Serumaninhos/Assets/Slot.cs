using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

    public bool empty;

    private bool hovered, used;
    public GameObject item;

    private GameObject player;

    public Texture itemIcon;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() {

        if (item) {
            empty = false;
            itemIcon = item.GetComponent<Item>().itemIcon;
            this.GetComponent<RawImage>().texture = itemIcon;

        } else{
            empty = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData) {

        hovered = true;

    }

    public void OnPointerExit(PointerEventData eventData) {
        hovered = false;
    }

    public void OnPointerClick(PointerEventData eventData) {

        if (item) {

            Item thisItem = item.GetComponent<Item>();

            if(thisItem.itemType == "Amarra") {

            }
        }

    }
}
