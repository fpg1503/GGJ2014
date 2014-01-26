using UnityEngine;
using System.Collections;

public class CardList : MonoBehaviour {

	public GameObject[] myCards;
	public float cardDistance;
	public float angle;
	public float raiseValue;
	public Player owner;
	public CardFactory myCardFactory;

	// Use this for initialization
	void Start ()
	{
		int i;
		for (i = 1; i <= myCards.Length; i++)
		{
			myCards [i - 1].transform.position = this.transform.position - cardDistance * (float)(i - (1 + 0.5 * (myCards.Length - 1))) * new Vector3 (Mathf.Cos (Mathf.Deg2Rad * angle), Mathf.Sin (Mathf.Deg2Rad * angle), 1);
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public float getAngle()
	{
		return angle;
	}

	public float getRaiseValue()
	{
		return raiseValue;
	}

	public Player getOwner()
	{
		return this.owner;
	}

	public int getNumberOfCards()
	{
		return this.myCards.Length;
	}

	public GameObject getCardAtIndex (int index)
	{
		return this.myCards[index];
	}

	public void removeCardAtIndex (int index)
	{
		//If I don't do it like that the player may get confused.
		for (int i = index; i < this.myCards.Length; i++)
		{
			this.myCards [i] = this.myCards [i + 1];
		}
	}

	public CardFactory getCardFactory()
	{
		return this.myCardFactory;
	}

	public void addCard(GameObject card)
	{
		this.myCards[this.myCards.Length] = card;
	}

	public void deselectAll()
	{
		int i;
		for(i = 0; i < myCards.Length; i++)
		{
			(myCards[i].GetComponent("Card") as Card).deselectCard();
		}
	}


}
