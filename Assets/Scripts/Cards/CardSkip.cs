using UnityEngine;
using System.Collections;

public class CardSkip : SelectPlayerCard
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void selectCard()
	{
		base.selectCard ();
		//Add a turn to skip for selected player
		this.getSelectedPlayer().addTurnSkip();
	}
	
}
