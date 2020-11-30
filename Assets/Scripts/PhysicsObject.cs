using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
	private Rigidbody rb;

	[SerializeField] private Vector3 _velocity = new Vector3(0, -1, 0);

	[SerializeField] private float _mass = 1f;
	[SerializeField] private float _drag = 0f;
	[SerializeField] private float _angularDrag = 0f;
	[SerializeField] private bool _useGravity = true;
	[SerializeField] private bool _isKinematic = false;

	private float _speed;

	public float Velocity { get; set; }

	public float Acceleration { get; set; }

	private Vector3 _accelerationVector;

	private void Update()
	{

	}

	private void ApplyVeloctiy()
	{
		Vector3 oldPosition = transform.position;

		Vector3 newPosition = oldPosition + _velocity * Time.deltaTime;

		transform.position = newPosition;
	}

	public void ApplyForce(float force)
	{

		Acceleration = force / _mass;

		//_velocity = _velocity + Acceleration * Time.deltaTime;

		_speed = MyMath.Magnitude(_velocity);

		transform.position = _velocity;
	}
}