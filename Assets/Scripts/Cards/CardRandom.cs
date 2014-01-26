using UnityEngine;
using System.Collections;

public class CardRandom : Card
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
		Card card = this.myCardList.getCardFactory ().buildRandomCard ();
		card.selectCard ();//TODO:After the card is used a message is displayed. Which one should we display?
		//FIXME: Possible random loop

		actionFinished();
	}
}
