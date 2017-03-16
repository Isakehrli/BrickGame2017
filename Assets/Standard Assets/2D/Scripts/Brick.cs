using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int hits = 1;
    public int points = 1;

    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        hits = hits - 1;
        //could be: hits -= 1;
        Debug.Log(hits);

        //GetComponent<SpriteRenderer> ().color = new Color (1,1,1, hits * .2f);

        if (hits == 0) {
            gameObject.SetActive(false);
            FindObjectOfType<ball>().YouBrokeABrick(points); //worth = points
        }

    }
}
