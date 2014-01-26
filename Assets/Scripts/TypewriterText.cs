using UnityEngine;
using System.Collections;

public class TypewriterText : MonoBehaviour
{
	public float letterPause = 0.2f;
	public AudioClip soundPress;
	public AudioClip soundSpace;
	public AudioClip soundEnter;



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
			AudioClip sound;
			switch (letter)
			{
			case ' ':
				sound = soundSpace;
				break;
			case '\n':
				sound = soundEnter;
				break;
			default:
				sound = soundPress;
				break;
			}

			if (sound)
				audio.PlayOneShot (sound);
				yield return 0;
			yield return new WaitForSeconds(letterPause * Random.Range(0.5f, 2.0f));

		}
	}
}
