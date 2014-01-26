using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {

	public GameObject defaultUnit;
	private GameObject[,] unitBoard;
	public float distance;
	// Use this for initialization

	void Start () {
		unitBoard = new GameObject[10,10];
		int i, j;
		for(i = 0; i < 10; i++)
			for(j = 0; j < 10; j++)
			{
				unitBoard[i,j] = Instantiate(defaultUnit) as GameObject;
				unitBoard[i,j].transform.position = this.transform.position + new Vector3(i - 4.5f, j - 4.5f, 0) * distance;
				(unitBoard[i,j].GetComponent("SimplePresser") as SimplePresser).setTarget(unitBoard[i,j]);
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
