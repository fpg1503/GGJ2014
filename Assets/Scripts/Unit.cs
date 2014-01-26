using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{

	private int colorType;
	private Player owner;

	// Use this for initialization
	void Start ()
	{
		colorType = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void changeColor()
	{
		colorType = (colorType + 1) % 5;

		switch(colorType)
		{
			case 0: (this.GetComponent("OTSprite") as OTSprite).tintColor = Color.white; break;
			case 1: (this.GetComponent("OTSprite") as OTSprite).tintColor = Color.blue; break;
			case 2: (this.GetComponent("OTSprite") as OTSprite).tintColor = Color.green; break;
			case 3: (this.GetComponent("OTSprite") as OTSprite).tintColor = Color.yellow; break;
			case 4: (this.GetComponent("OTSprite") as OTSprite).tintColor = Color.red; break;
		}

		Debug.Log("hey");
	}

	public void setOwner (Player owner)
	{
		this.owner = owner;
		
		//play ownership change animation
	}
	
	public Player getOwner ()
	{
		return this.owner;
	}
}
