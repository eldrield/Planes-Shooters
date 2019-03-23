using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
	#region Main

	private void Awake()
	{
		Destroy( gameObject , 0.5f );
	}

	#endregion

}
