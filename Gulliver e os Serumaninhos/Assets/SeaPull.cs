using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaPull :MonoBehaviour {

    private Vector2 previousPos, atualPos;

    private GameObject collisor;

void SeaPulling() {
        Rigidbody2D rB;

        atualPos = new Vector2(Random.Range(1.0f, -0.2f), Random.Range(0.1f, -0.1f));

        previousPos = new Vector2(transform.position.x + Random.Range(-2,0), transform.position.y + Random.Range(0.08f, -0.1f));
        rB = collisor.GetComponent<Rigidbody2D>();

        rB.velocity = previousPos;



        collisor.transform.position = atualPos;
        previousPos = atualPos;

    //    yield return new WaitForSeconds(1f);

    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == "Item") {

            collisor = collision.gameObject;
            previousPos = collisor.transform.position;
            SeaPulling();

        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Item") {

            collisor.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        }
    }
}
