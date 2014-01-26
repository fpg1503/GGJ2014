using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	
	public enum ColorType
	{
		green,
		red,
		yellow,
		blue
	}
	
	private CardList cards;
	private Unit[] units;
	private ColorType color;
	public OTSprite _sprite;
	private int turnsToSkip;
	
	
	// Use this for initialization
	void Start ()
	{
		this.cards = new CardList();
		this.turnsToSkip = 0; 
	}
	
	public CardList getCards ()
	{
		return this.cards;
	}

	public void addTurnSkip ()
	{
		turnsToSkip++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
