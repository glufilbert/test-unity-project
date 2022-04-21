using UnityEngine;
using System;
using System.Collections;

public class MyScript : MonoBehaviour
{
	public AnotherScript anotherScript;
	public struct MyStruct
    {
		public int myVal;
    }
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log(anotherScript?.MyInt ?? 0);
		try
		{
			MyStruct thing = new MyStruct();
			Thing(2);
			CoroutineThing();
		}
		catch (Exception e)
		{
			Debug.Log(e.Message);
			throw;
		}
	}

	public void OnGUI()
	{
		// do nothing.
	}

	private IEnumerator CoroutineThing()
	{
		yield return null;
	}

	private void Thing(int aVar)
	{
		Debug.Log("Hello");
	}
}
