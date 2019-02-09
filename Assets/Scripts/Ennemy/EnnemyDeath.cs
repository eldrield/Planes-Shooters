using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyDeath : MonoBehaviour
{
	#region Public Members

	

	#endregion
    

	#region System

	private void Awake()
	{
		m_playerHealth = GameObject.Find( "Player" );	
	}

	#endregion


	#region Main

	private void OnCollisionEnter2D( Collision2D _coll )
	{
		if ( _coll.gameObject.name == "ennemyDeadLine" )
		{
			Destroy( gameObject );
			m_playerHealth.GetComponent<Health>().Hit(1);
		}
	}
	private void OnTriggerEnter2D( Collider2D _coll )
	{
		if ( _coll.gameObject.name == "ennemyDeadLine" )
		{

			Destroy( gameObject );
		}
	}

	#endregion

	#region Private
	
	private GameObject m_playerHealth;

	#endregion
}
