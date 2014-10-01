using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


	public Vector3 speed = new Vector3(50, 50, 0);
	
	// 2 - Store the movement
	private Vector2 movement;
	
	void Update()
	{
		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 4 - Movement per direction
		movement = new Vector3(
			speed.x * inputX,
			speed.y * inputY,
			0				);
			
		
	}
	
	void FixedUpdate()
	{
		// 5 - Move the game object
		rigidbody.velocity = movement;
	}
}
