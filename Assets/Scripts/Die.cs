using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {

    GameController gameController;
    public float speedRotate;
    public float speed;
	// Use this for initialization
	void Start ()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
      float movz =  Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotY = Input.GetAxis("Horizontal") * speedRotate * Time.deltaTime;

        transform.Translate(0, 0, movz);
        transform.Rotate(0, rotY, 0);
	}

     void OnCollisionEnter(Collision trigger)
    {
        if(trigger.gameObject.tag == "Enemy")
        {
            gameController.Lose();
            enabled = false;
        }
    }
}
