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
	private List<Guy> guys;
	private ColorType color;
	public OTSprite _sprite;
	
	
	// Use this for initialization
	void Start ()
	{
		this.cards = new CardList();
		this.guys = new Array<Guy>();
	}
	
	public CardList getCards ()
	{
		return this.cards;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
