using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public string objectName, description;

    public int duration, durationCount;

    private void OnMouseDrag() {

        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        Vector2 objPos = Camera.main.ScreenToWorldPoint(mousePosition);

        gameObject.transform.position = objPos;

    }

    private void Update() {
        
        if (duration <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.tag == "Amarra") {

            duration -= 1;
            collision.gameObject.GetComponent<AmarraStatus>().resistence -= 1;
            print("Para Meu");
        }


    }

    private void NextDay() {
        Destroy(gameObject);
    }

    private void OnDestroy() {
        //animation.setBool("DestroyItem",true);
    }

}
