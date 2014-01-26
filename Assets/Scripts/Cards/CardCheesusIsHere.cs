using UnityEngine;
using System.Collections;

public class CardCheesusIsHere : SelectUnitCard
{

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
		//CHESUS IS HERE
		this.getSelectedUnit().setOwner(this.myCardList.getOwner());
		//The selected Unit now follows the card owner Dictator

		actionFinished();
	}
}
