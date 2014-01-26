using UnityEngine;
using System.Collections;

public class CardChesusIsHere : SelectUnitCard
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
		//CHESUS IS HERE
		this.getSelectedUnit().setOwner(this.myCardList.getOwner());
		//The selected Unit now follows the card owner Dictator
	}
}
