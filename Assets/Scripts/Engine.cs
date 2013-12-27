using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour
{
	public float deltaV;
	public float deltaW;
	public Rigidbody2D rigidbody2d;
	// Use this for initialization
	void Start ()
	{
	
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.W)) {
			rigidbody2d.AddForce ((transform.rotation * Vector2.up) * deltaV * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.S)) {
			rigidbody2d.AddForce (-(transform.rotation * Vector2.up) * deltaV * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.A)) {
			rigidbody2d.AddTorque (deltaW * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D)) {
			rigidbody2d.AddTorque (-deltaW * Time.deltaTime);
		}
	}
}
