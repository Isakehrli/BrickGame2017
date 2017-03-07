using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    int hits = 2;
	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        hits = hits - 1;
        if(hits == 0)
        gameObject.SetActive(false);
    }
}
