using UnityEngine;
using System.Collections;

public class CardDoubleUp : Card
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
		//Dice value is now doubled
	}
}
