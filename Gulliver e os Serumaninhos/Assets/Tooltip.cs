using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

    public string ObjectName, ObjectInfo;

    private void Update() {
        SetObjectName();
    }

    public GameObject tooltip;

    public Text textName,textInfo;

    private void OnMouseEnter() {

        tooltip.SetActive(true);

        if (tooltip != null) {
            textInfo.text = ObjectInfo;
            textName.text = ObjectName;
        }
    }

    private void OnMouseExit() {
        tooltip.SetActive(false);
    }


    void SetObjectName() {
        if (this.gameObject.GetComponent<AmarraStatus>() != null) {
            ObjectName = "Amarra de "+this.gameObject.GetComponent<AmarraStatus>().selectedMaterial;
            ObjectInfo = "Resistencia: " + this.gameObject.GetComponent<AmarraStatus>().resistence;
        }
    }


}
