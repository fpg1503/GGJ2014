using UnityEngine;
using System.Collections;


public class SimplePresser : MonoBehaviour {
	
	public string methodToInvokeClick;
	public string scriptWithMethod;
	private OTSprite sprite;
	public GameObject target;
	private bool buttonPressed;
	private bool active;

	// Use this for initialization
	void Start () {
		gameObject.AddComponent(typeof(BoxCollider));
		sprite = gameObject.GetComponent<OTSprite>();
		buttonPressed = false;
	}

	public void setTarget(GameObject go)
	{
		target = go;
		gameObject.AddComponent(typeof(BoxCollider));
		sprite = gameObject.GetComponent<OTSprite>();
		buttonPressed = false;
	}
	
	// Update is called once per frame
	void Update () {

			if(OT.Clicked(gameObject)){
			//Debug.Log("haha");
				sprite.frameIndex = 1;
				buttonPressed = true;
				MonoBehaviour temp = (MonoBehaviour) target.GetComponent(scriptWithMethod);
			//	temp.Invoke(methodToInvokeClick, 0);
			}
			
			if(buttonPressed && !OT.Over(gameObject)){
				//sprite.frameIndex = 0;	
				buttonPressed = false;
			}

			if(buttonPressed && !OT.ClickedContinuous(gameObject, 0))
			{
				MonoBehaviour temp = (MonoBehaviour) target.GetComponent(scriptWithMethod);
				temp.Invoke(methodToInvokeClick, 0);
				//sprite.frameIndex = 0;
				buttonPressed = false;

			}
			
			//if(!buttonPressed){
				//sprite.frameIndex = 0;
			//}
	}
}