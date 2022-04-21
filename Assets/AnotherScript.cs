using UnityEngine;

public class AnotherScript : MonoBehaviour
{
	[SerializeField] private int myInt;

	public int MyInt => myInt;
}
