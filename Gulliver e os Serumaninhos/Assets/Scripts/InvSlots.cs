using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvSlots : MonoBehaviour {

    [SerializeField] Image image;

    private InvItem _item;
    public InvItem InvItem {

        get{ return _item; }
        set {
            _item = value;
            if(_item == null) {
                image.enabled = false;
            } else {
                image.sprite = _item.Icon;
                image.enabled = true;
            }
        }
    }

    private void OnValidate() {
        if (image == null) {
            image = GetComponent<Image>();
        }
    }
}
