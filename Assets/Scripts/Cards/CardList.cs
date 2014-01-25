using UnityEngine;
using System.Collections;

public class CardList : MonoBehaviour {

	public GameObject[] myCards;
	public float cardDistance;
	public float angle;
	public float raiseValue;

	// Use this for initialization
	void Start () {
		int i;
		for(i = 1; i <= myCards.Length; i++)
			myCards[i-1].transform.position = this.transform.position - cardDistance * (float)(i - (1 + 0.5*(myCards.Length - 1))) * new Vector3(Mathf.Cos(Mathf.Deg2Rad*angle), Mathf.Sin(Mathf.Deg2Rad*angle), 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float getAngle()
	{
		return angle;
	}

	public float getRaiseValue()
	{
		return raiseValue;
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
