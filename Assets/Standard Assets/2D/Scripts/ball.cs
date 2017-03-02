using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    public Vector2 startingVelocity = new Vector2(15, -20);

    void Start() {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
    }
	void Update () {
		if(transform.position.y < -2.5f) {
                GetOut();
            }
	}
     void GetOut()
        {
            Debug.Log("You are out");
        }
}
