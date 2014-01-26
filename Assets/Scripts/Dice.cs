using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour
{
	
	
	private bool moving = false;
	private Vector3 direction;
	private int rotations;

	public Texture blueTexture;
	public Texture greenTexture;
	public Texture redTexture;
	public Texture yellowTexture;

	public float spinDuration;

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
				Debug.Log(getResult());
			}
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		MeshRenderer mr = gameObject.GetComponent("MeshRenderer") as MeshRenderer;

		int colorType = Random.Range (0, 4);
		switch(colorType)
		{
			case 0: mr.material.SetTexture ("_MainTex", blueTexture); break;
			case 1: mr.material.SetTexture ("_MainTex", greenTexture); break;
			case 2: mr.material.SetTexture ("_MainTex", redTexture); break;
			case 3: mr.material.SetTexture ("_MainTex", yellowTexture); break;
		}



		rotations = Random.Range(13, 20);
		StartCoroutine(RotateFromTo( transform.rotation,  Quaternion.AngleAxis(90, Vector3.up), spinDuration));
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
			
			
			StartCoroutine (RotateFromTo (transform.rotation, Quaternion.AngleAxis (90*Random.Range(1,3), direction), spinDuration));
		}
	}

	public int getResult ()
	{
		Vector3 newFwd = gameObject.transform.rotation * Vector3.forward;

		Debug.Log (newFwd);
		/* ( 0.0f,  0.0f, -1.0f) 1
		 * ( 0.0f, -1.0f,  0.0f) 2
		 * (-1.0f,  0.0f,  0.0f) 3
		 * (+1.0f,  0.0f,  0.0f) 4
		 * ( 0.0f, +1.0f,  0.0f) 5
		 * ( 0.0f,  0.0f, +1.0f) 6
		 * */

		Vector3[] sides = 
		{new Vector3 ( 0.0f,  0.0f, -1.0f),  //1
		 new Vector3 ( 0.0f, -1.0f,  0.0f),  //2
		 new Vector3 (-1.0f,  0.0f,  0.0f),  //3
		 new Vector3 (+1.0f,  0.0f,  0.0f),  //4
		 new Vector3 ( 0.0f, +1.0f,  0.0f),  //5
		 new Vector3 ( 0.0f,  0.0f, +1.0f)   //6
		};

		for (int i = 0; i < sides.Length; i++)
		{
			if (newFwd == sides[i])
			{
				return i+1;
			}
		}

		return 0;
	}
}
