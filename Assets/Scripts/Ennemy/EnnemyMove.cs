using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
	#region Public

	public float m_speed;

	#endregion


	#region System

	private void Awake()
	{
		m_transform = gameObject.GetComponent<Transform>();
	}

	private void Update()
	{
		Vector2 movement = new Vector2( 0f , -1f );
		Vector2 position = m_transform.position;
		position += movement * m_speed * Time.deltaTime;
		m_transform.position = position;
	}

	#endregion



	#region Private and Protected Members

	private Transform m_transform;

    #endregion

}
