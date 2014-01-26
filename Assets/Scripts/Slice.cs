using UnityEngine;
using System.Collections;

public class Slice : MonoBehaviour {

	public Vector3 origin;
	public Vector3 goal;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void finishTween(OTTween tween)
	{
		shade(Color.white);
	}

	public void shade(Color color)
	{
		(this.GetComponent("OTSprite") as OTSprite).tintColor = color;
	}

	public void move()
	{
		OTTween tween = new OTTween(this.transform,0.6f);
		tween.Tween("position",origin,goal,OTEasing.QuadIn);
	}

	public void remove()
	{
		OTTween tween = new OTTween(this.transform,0.6f);
		//tween.onTweenFinish = finishTween;

		tween.Tween("position",goal,origin,OTEasing.QuadIn);
	}
}
