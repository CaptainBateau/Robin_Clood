using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float _horizontalSpeed;
	public float _verticalSpeed;

	void Update()
	{
		if (Input.GetAxis("Horizontal") != 0)
		{
			transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * _horizontalSpeed * Time.deltaTime);
		}

		if (Input.GetAxis("Vertical") != 0)
		{
			transform.Translate(Input.GetAxis("Vertical") * Vector3.up * _verticalSpeed * Time.deltaTime);
		}
	}
}
