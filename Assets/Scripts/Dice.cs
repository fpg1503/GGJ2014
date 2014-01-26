using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour
{
	
	
	private bool moving = false;
	private Vector3 direction;
	private int rotations;
	
	IEnumerator RotateFromTo(Quaternion pointA, Quaternion pointB, float time)
	{
		if (!moving)
		{ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.rotation = Quaternion.Lerp(pointA, pointB, t); // set position proportional to t
				yield return 0; // leave the routine and return here in the next frame
			}
			moving = false; // finished moving
			rotations--;
			if (rotations == 0)
			{
				//TODO: notify
			}
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		rotations = Random.Range(13, 20);
		StartCoroutine(RotateFromTo( transform.rotation,  Quaternion.AngleAxis(90, Vector3.up), 0.2f));
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!moving && rotations > 0)
		{
			int rand =  Random.Range (0,4);
			Vector3 newDirection;
			switch (rand)
			{
			case 0:
				newDirection = Vector3.up;
				break;
			case 1:
				newDirection = Vector3.right;
				break;
			case 2:
				newDirection = Vector3.down;
				break;
			case 3:
				newDirection = Vector3.left;
				break;
			default:
				newDirection = Vector3.zero;
				break;
			}
			
			direction = (direction == newDirection) ? Vector3.zero : newDirection;
			
			
			StartCoroutine (RotateFromTo (transform.rotation, Quaternion.AngleAxis (90*Random.Range(1,3), direction), 1f));
		}
	}
}
