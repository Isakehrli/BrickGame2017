﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {

    public Vector2 startingVelocity = new Vector2(15, -20);
    private Vector3 startingPosition;
    public GameObject gameOverSign;
    public GameObject youWinSign;
    public Text livesValue;
    public Text pointsValue;

    int lives = 3;
    int points = 0;

    void Start() {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;

        livesValue = GameObject.Find("LivesValue").GetComponent<Text>();
    }
	void Update () {
		if(transform.position.y < -2.5f) {
                GetOut();
        }
        if (Input.GetButtonDown("Jump")) {
            GetComponent<Rigidbody2D>().velocity = startingVelocity;
            livesValue.text = lives.ToString();
        }
	}
     void GetOut()
        {
            Debug.Log("You are out");
        lives = lives - 1;
        livesValue.text = lives.ToString();

        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();
        if (lives == 0) {
            DoGameOver();
        }
        }

    void DoGameOver()
    {
        gameOverSign.SetActive(true);
    }

    public void YouBrokeABrick(int worth)
    {
        points += worth;
        pointsValue.text = points.ToString();
        var bricksLeft = FindObjectsOfType<Brick>().Length;
        if(bricksLeft == 0) {
            youWinSign.SetActive(true);
        }
    }
}
