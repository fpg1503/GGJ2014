using UnityEngine;
using System.Collections;

public class TypewriterText : MonoBehaviour
{
	public float letterPause = 0.2f;
	private AudioClip sound;

	string message;

	// Use this for initialization
	void Start ()
	{
		message = guiText.text;
		guiText.text = "";
		StartCoroutine(typeText ());
	}

	IEnumerator typeText ()
	{
		foreach (char letter in this.message.ToCharArray())
		{
			guiText.text += letter;
			if (sound)
				audio.PlayOneShot (sound);
				yield return 0;
			yield return new WaitForSeconds(letterPause * Random.Range(0.5f, 2.0f));

		}
	}
}
