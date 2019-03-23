using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColl : MonoBehaviour
{
	#region System

	private void Awake()
	{
		m_damage = 1;
	}
	private void OnCollisionEnter2D( Collision2D _coll )
	{
		if ( _coll.gameObject.tag == "Ennemies" )
		{
			_coll.gameObject.GetComponent<Health>().Hit( m_damage );
			Destroy( gameObject );
        }
		if (_coll.gameObject.tag == "BulletDeath")
		{
			Destroy(gameObject);
		}
	}


	#endregion


	#region Private and Protected Members

	private float m_damage;

	#endregion
}
