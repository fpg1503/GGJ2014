using UnityEngine;
using System.Collections;

public class TextureCorrespondence : MonoBehaviour {

	public static Texture[] spriteList;
	public Texture[] _spriteList;

	// Use this for initialization
	void Start () {
		int i;
		for (i=0; i< _spriteList.Length; i++)
						spriteList[i] = _spriteList[i];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static Texture getTextureAt(int index)
	{
		return spriteList [index];
	}
}
