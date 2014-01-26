using UnityEngine;
using System.Collections;

public class SelectPlayerCard : Card
{

	private Player selectedPlayer;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public Player getSelectedPlayer()
	{
		return this.selectedPlayer;
	}

	public void performAction()
	{
		base.performAction ();
		//Ask which Player
		//TODO
	}
}
