using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int hits = 1;

	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        hits = hits - 1;
        //could be: hits -= 1;
        Debug.Log(hits);

        if (hits == 0) {
            gameObject.SetActive(false);
            FindObjectOfType<ball>().YouBrokeABrick();
        }

    }
}
