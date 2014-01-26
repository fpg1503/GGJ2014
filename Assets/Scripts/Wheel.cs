using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour {

	public GameObject[] sliceList;

	// Use this for initialization
	void Start () {
		closeWheel(1,2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void closeWheel(int playerOne, int playerTwo)
	{
		int i;

		for(i = 0; i< 4; i++)
			(sliceList[i].GetComponent("Slice") as Slice).shade(new Color(0.17f, 0.17f, 0.17f));

		(sliceList[playerOne].GetComponent("Slice") as Slice).shade(Color.white);
		(sliceList[playerTwo].GetComponent("Slice") as Slice).shade(Color.white);

		for(i = 0; i< 4; i++)
			(sliceList[i].GetComponent("Slice") as Slice).move();
	}

	public void openWheel()
	{
		int i;
		
		for(i = 0; i< 4; i++)
			(sliceList[i].GetComponent("Slice") as Slice).remove();
	}

	public void minigameMode()
	{

		int i;
			
		for(i = 0; i< 4; i++)
		{
			OTSprite sprite = sliceList[i].GetComponent("OTSprite") as OTSprite;
			OTTween size = new OTTween(sprite,0.6f);
			size.Tween("size",sprite.size*0.8f,OTEasing.QuadIn);

		}
	}

}
