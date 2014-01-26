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
				Card card = cardList.getCardAtIndex(j) as Card;
				vals[i][j] = card.getVal();
			}
		}
		//
		makeCorrespondence ();

		//For each player
		for (int i = 0; i < cardLists.Length; i++)
		{
			CardList cardList = cardLists[i];
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

	public Card buildCard(int val)
	{
		Card card = null;
			string s = "";
		switch (correspondence[val]) 
		{
			case 0: s = "DOUBLE UP!";/*card = new CardDoubleUp();*/ break;
			case 1: s = "KAMICLONE!";/*card = new CardChesusIsHere();*/ break;
			case 2: s = "SKIP!"; break;
			case 3: s = "CONVERT!"; break;
			case 4: s = "+3 UNITS!"; break;
			case 5: s = "REVERSE!"; break;
			case 6: s = "-3 UNITS!"; break;
			case 7: s = "EXTRA DICE!"; break;
			case 8: s = "STEAL!"; break;
			case 9: s = "RANDOM!"; break;
			case 11: s = "SHUFFLE!"; break;
			case 12: s = "WIN!"; break;
			case 13: s = "+WALL!"; break;
			case 14: s = "-WALL!"; break;
				default: s = "OUT OF BOUNDS!"; break; //return null;
		}

			Debug.Log (val+" equivale a " + s);

		card.setVal(val);
		return card;
	}

}
