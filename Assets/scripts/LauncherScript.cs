using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherScript : MonoBehaviour
{

public float distance = 1.2f;
public float speed = 1.0f;
public GameObject ball;
public float power = 2000.0f;

private bool ready = false;
private bool fire = false;
float moveCount = 0.0f;

public void OnCollisionEnter(Collision collision) {
	if(collision.gameObject.tag == "ball"){
		ready = true;
	}
}

void Update () {

	if(Input.GetKey(KeyCode.Space) && ready){
		//As the button is held down, slowly move the piece
		if(moveCount < distance){
			transform.Translate(0,-speed * Time.deltaTime,0);
			moveCount += speed * Time.deltaTime;
			fire = true;
		}
	}
	else if(moveCount > 0){
		//Shoot the ball
		if(fire && ready){
			ball.transform.TransformDirection(Vector3.forward * 10);
			ball.GetComponent<Rigidbody>().AddForce(0, 0, moveCount * power);
			fire = false;
			ready = false;
		}
		//Once we have reached the starting position fire off!
		transform.Translate(0,10 * Time.deltaTime,0);
		moveCount -= 10 * Time.deltaTime;
	}
	
	//Just ensure we don't go past the end
	if(moveCount <= 0){
		fire = false;
		moveCount = 0;
	}

}
}
