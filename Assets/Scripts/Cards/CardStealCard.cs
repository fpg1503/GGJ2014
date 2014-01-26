using UnityEngine;
using System.Collections;

public class CardStealCard : SelectPlayerCard
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
		//Get a random card from target
		CardList cardList = this.getSelectedPlayer().getCards();
		Player newOwner = this.myCardList.getOwner();
		//check
		int cardIndex = Random.Range(0, cardList.getNumberOfCards());
		GameObject card = cardList.getCardAtIndex (cardIndex);
		//Remove it from the old owner
		this.getSelectedPlayer().getCards().removeCardAtIndex(cardIndex);
		//And give it to the new one
		newOwner.getCards().addCard(card);
	}
}
