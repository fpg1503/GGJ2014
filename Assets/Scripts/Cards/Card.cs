using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	
	private bool selected;
	private string shortDescription;
	private string longDescription;

	public GameObject myCardListGO;
	protected CardList myCardList;

	public float angle;
	public float raiseValue;

	private int spriteType;

	private int val;

	// Use this for initialization
	void Start () {
		selected = false;
		myCardList = myCardListGO.GetComponent("CardList") as CardList;
		angle = myCardList.getAngle();
		raiseValue = myCardList.getRaiseValue();
	}
	
	// Update is called once per frame
	void Update () {
		//(this.GetComponent("OTSprite") as OTSprite).rotation = -angle;
	}

	public void setSprite(int val)
	{
		(this.GetComponent ("OTSprite") as OTSprite).image = TextureCorrespondence.getTextureAt (val);
	}

	public bool isSelected()
	{
		return selected;
	}
	
	public void selectCard()
	{
		if(selected)
			return;

		Vector3 goal = this.transform.position + raiseValue * new Vector3(Mathf.Sin(Mathf.Deg2Rad*angle), Mathf.Cos(Mathf.Deg2Rad*angle), 0);

		OTTween tween = new OTTween(this.transform,0.3f);
		tween.Tween("position",goal,OTEasing.QuadOut);

		myCardList.deselectAll();
		selected = !selected;

		Debug.Log(goal);
	}

	public void deselectCard()
	{
		if(!selected)
			return;

		Vector3 goal = this.transform.position - raiseValue * new Vector3(Mathf.Sin(Mathf.Deg2Rad*angle), Mathf.Cos(Mathf.Deg2Rad*angle), 0);
		
		OTTween tween = new OTTween(this.transform,0.3f);
		tween.Tween("position",goal,OTEasing.QuadOut);
		selected = false;
		Debug.Log(goal);
	}

	public int getVal()
	{
		return this.val;
	}

	public void setVal(int val)
	{
		this.val = val;
	}

}
