using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip :MonoBehaviour {

    public int value;

    public string ObjectName, ObjectInfo;

    private GameObject tooltip;

    public Text textName, textInfo;

    private GameObject tooltipName, tooltipText;
    private bool isClicking;

    private void Start() {


        tooltip = GameObject.FindGameObjectWithTag("TooltipLeft");
        tooltipName = GameObject.FindGameObjectWithTag("TNameLeft");
        tooltipText = GameObject.FindGameObjectWithTag("TTextLeft");

        tooltip.GetComponentInParent<Canvas>().enabled = false;
    }

    private void Update() {
        SetObjectName();
    }

    private void OnMouseEnter() {

        if (this.gameObject.GetComponent<AmarraStatus>() != null) {
            Vector2 vec = new Vector2(20, tooltip.transform.position.y);
            tooltip.transform.SetPositionAndRotation(vec, Quaternion.identity);
            tooltipName.GetComponent<Text>().color = Color.cyan;
            tooltipText.GetComponent<Text>().color = Color.cyan;

        } else {
            Vector2 vec = new Vector2(500, tooltip.transform.position.y);
            tooltip.transform.SetPositionAndRotation(vec, Quaternion.identity);
            tooltipName.GetComponent<Text>().color = Color.yellow;
            tooltipText.GetComponent<Text>().color = Color.yellow;
        }
        if (tooltip != null) {
            tooltipName.GetComponent<Text>().text = ObjectName;

            tooltipText.GetComponent<Text>().text = ObjectInfo;
        }

        tooltip.GetComponentInParent<Canvas>().enabled = true;

    }
     
    private void OnMouseDrag() {
        tooltip.GetComponentInParent<Canvas>().enabled = false;
    }

    private void OnMouseExit() {
        tooltip.GetComponentInParent<Canvas>().enabled = false;
    }

    void SetObjectName() {
        if (this.gameObject.GetComponent<AmarraStatus>() != null) {
            ObjectName = "Amarra de " + this.gameObject.GetComponent<AmarraStatus>().selectedMaterial;
            ObjectInfo = "Resistencia: " + this.gameObject.GetComponent<AmarraStatus>().resistence;
        }
        if (this.gameObject.GetComponent<Item>() != null) {
            ObjectName = this.gameObject.GetComponent<Item>().objectName;
            ObjectInfo = this.gameObject.GetComponent<Item>().description;
        }
    }
}
