using UnityEngine;
using System.Collections;

public class ChoiceButtonManager : MonoBehaviour
{
    public GameObject DoneButton;
	public int ClickCount
	{
		get
		{
			return _clickCount;
		}
		set
		{
			if(value >= 3)
			{
				DoneButton.GetComponent<Renderer>().enabled = false;
				DoneButton.GetComponent<BoxCollider2D>().enabled = true;
			}
			_clickCount = value;
		}
	}
	private int _clickCount;
}
