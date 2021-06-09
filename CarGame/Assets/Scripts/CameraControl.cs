using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	//TODO: get mouse look to be mapped to the area of the window and not the area of the display?
	//bless reddit https://www.reddit.com/r/Unity3D/comments/8k7w7v/unity_simple_mouselook/
	Vector2 rotation = Vector2.zero; //zero out the rotation
	public float speed = 3;
	//NOTE, the floats don't map at all to the transform units in game, jsyk
	public float clampUp = 5f;
	public float clampDown = -2f;
	public float clampLeft = 8f;
	public float clampRight = -8f;

	void Update()
	{
		rotation.y += Input.GetAxis("Mouse X"); //maps the rotation y to 
		rotation.x += -Input.GetAxis("Mouse Y");
		rotation.x = Mathf.Clamp(rotation.x, clampDown, clampUp); //clamps the up/down position
		rotation.y = Mathf.Clamp(rotation.y, clampLeft, clampRight);
		transform.eulerAngles = (Vector2)rotation * speed;
	}
}
