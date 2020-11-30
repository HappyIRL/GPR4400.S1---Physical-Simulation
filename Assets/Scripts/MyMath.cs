using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
	//private static MyMath _instance;
	//private static bool _hasInstance = false;
	//public static MyMath Instance
	//{
	//	get
	//	{
	//		if(_instance == null)
	//		{
	//			_instance = new MyMath();
	//			_hasInstance = true;
	//		}
	//		return _instance;
	//	}
	//	set
	//	{
	//		if(_hasInstance)
	//		{
	//			return;
	//		}
	//		_instance = value;
	//		_hasInstance = true;
	//	}
	//}


	public static Vector3 AsUnitVector(Vector3 vector, float scaler)
	{
		float xNomralized = vector.x / Mathf.Sqrt(Mathf.Pow(vector.x, 2) + Mathf.Pow(vector.y, 2) + Mathf.Pow(vector.z, 2));
		float yNormalized = vector.y / Mathf.Sqrt(Mathf.Pow(vector.x, 2) + Mathf.Pow(vector.y, 2) + Mathf.Pow(vector.z, 2));
		float zNormalized = vector.z / Mathf.Sqrt(Mathf.Pow(vector.x, 2) + Mathf.Pow(vector.y, 2) + Mathf.Pow(vector.z, 2));

		return new Vector3(xNomralized * scaler, yNormalized * scaler, zNormalized * scaler);
	}

	public static float Magnitude(Vector3 vector)
	{
		float magnitude = Mathf.Sqrt(Mathf.Pow(vector.x, 2) + Mathf.Pow(vector.y, 2) + Mathf.Pow(vector.z, 2));

		return magnitude;
	}


}
