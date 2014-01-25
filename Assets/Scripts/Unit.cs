using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
	private Player owner;
	
	// Use this for initialization
	void Start ()
	{
		this.owner = null;
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
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
