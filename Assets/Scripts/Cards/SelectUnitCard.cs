using UnityEngine;
using System.Collections;

public class SelectUnitCard : Card
{
	private Unit selectedUnit;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public Unit getSelectedUnit()
	{
		return this.selectedUnit;
	}

	public void performAction()
	{
		base.performAction();
		//Ask which Unit
		//TODO
	}
}
