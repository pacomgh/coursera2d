using UnityEngine;
using System.Collections;

public class ControlEnemigo : MonoBehaviour {

    public float velocity = -1f;
    Rigidbody2D rigidBody;


	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 v = new Vector2(velocity, 0);
        rigidBody.velocity = v;
	
	}
}
