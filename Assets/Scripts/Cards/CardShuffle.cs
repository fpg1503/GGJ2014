using UnityEngine;
using System.Collections;

public class CardShuffle : Card {

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void performAction()
	{
		base.performAction ();
		//Shuffle cards
		this.myCardList.getCardFactory().shuffle();

		actionFinished();
	}
}
