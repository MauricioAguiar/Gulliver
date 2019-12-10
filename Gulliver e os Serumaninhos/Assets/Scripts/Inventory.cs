using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    [SerializeField] List<InvItem> items;
    [SerializeField] Transform itemsParent;
    [SerializeField] InvSlots[] itemSlots;


    private void OnValidate() {
        
        if (itemsParent != null)
            itemSlots = itemsParent.GetComponentsInChildren<InvSlots>();
        RefreshUI();
    }

    private void RefreshUI() {
        int i = 0;

        for (; i < items.Count && i < itemSlots.Length; i++) {
            itemSlots[i].InvItem = items[i];
        }

        for (; i < itemSlots.Length; i ++) {
            itemSlots[i].InvItem = null;
        }
    }

    public bool RemoveItem(InvItem item) {
        if (items.Remove(item)) {
            RefreshUI();
            return true;
        }
        return false;
    }

    public bool AddItem(InvItem item) {

        if (IsFull()) {
            return false;
        }
        items.Add(item);
        RefreshUI();
        return true;
    }

    private bool IsFull() {
        return items.Count >= itemSlots.Length;
    }
}
