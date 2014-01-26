using UnityEngine;
using System.Collections;

public class CardFactory : MonoBehaviour
{
	private int[] correspondence;
	private ArrayList availableNumbers;
	public CardList[] cardLists;

	// Use this for initialization
	void Start ()
	{
		makeCorrespondence();
		int i;
		for(i=0; i<20; i++)
			buildCard(Random.Range(0,13));
	}

	public void makeCorrespondence()
	{
		correspondence = new int[15];
		availableNumbers = new ArrayList();
		int i;
		for (i=0; i<15; i++)
			availableNumbers.Add (i);
		
		for (i=0; i<15; i++) 
		{
			int rand = Random.Range (0,availableNumbers.Count - 1);
			correspondence[i] = (int)availableNumbers.ToArray().GetValue(rand);
			//Debug.Log(availableNumbers.Count - 1 + ","+ correspondence[i]);
			availableNumbers.RemoveAt(rand);
		}
	}

	public void shuffle ()
	{
		int[][] vals = new int[cardLists.Length][];
		//For each player
		for (int i = 0; i < cardLists.Length; i++)
		{
			CardList cardList = cardLists[i];
			int cards = cardList.getNumberOfCards();
			vals[i] = new int[cards];
			//Copy each of their cards symbol
			for (int j = 0; j < cards; j++)
			{
				Card card = (cardList.getCardAtIndex(j).GetComponent("Card")) as Card;
				vals[i][j] = card.getVal();
			}
		}
		//
		makeCorrespondence ();

		//For each player
		for (int i = 0; i < cardLists.Length; i++)
		{
			CardList cardList = cardLists[i];
			int cards = cardList.getNumberOfCards();
			//Recreate cards with the same symbols
			for (int j = 0; j < cards; j++)
			{
				//Create card with val
				Card newCard = buildCard(vals[i][j]);
				//Create card Game Object with card
				//TODO:this/\
			}
		}
	}
	// Update is called once per frame
	void Update ()
	{

	}
	public Card buildRandomCard()
	{
		int random = 0;//FIXME
		return buildCard(random);
	}
	public Card buildCard(int val)
	{
		Card card = null;
			string s = "";
		switch (correspondence[val]) 
		{
			case 0: s = "DOUBLE UP!";card = new CardDoubleUp(); break;
			case 1: s = "KAMICLONE!";card = new Card(); break;
			case 2: s = "SKIP!";card = new CardSkip(); break;
			case 3: s = "CONVERT!";card = new CardCheesusIsHere(); break;
			case 4: s = "+3 UNITS!";card = new Card(); break;
			case 5: s = "REVERSE!";card = new Card(); break;
			case 6: s = "-3 UNITS!";card = new Card(); break;
			case 7: s = "EXTRA DICE!";card = new Card(); break;
			case 8: s = "STEAL!";card = new CardStealCard(); break;
			case 9: s = "RANDOM!";card = new CardRandom(); break;
			case 11: s = "SHUFFLE!";card = new CardShuffle(); break;
			case 12: s = "WIN!";card = new Card(); break;
			case 13: s = "+WALL!";card = new Card(); break;
			case 14: s = "-WALL!";card = new Card(); break;
				default: s = "OUT OF BOUNDS!"; break; //return null;
		}

			Debug.Log (val+" equivale a " + s);

		card.setVal(val);
		return card;
	}

}
