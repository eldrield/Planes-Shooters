using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnnemyColl : MonoBehaviour 
{

	#region System

	private void Awake()
	{
		m_damage = 1;
	}
    
	private void OnCollisionEnter2D( Collision2D _coll )
    {
        if ( _coll.gameObject.tag == "Player" )
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
			_coll.gameObject.GetComponent<Health>().Hit( m_damage );
			Destroy(gameObject);
        }
		if( _coll.gameObject.name == "ennemyDeadLine")
		{
			Destroy(gameObject);
		}
		if (_coll.gameObject.name == "BlueLasersLine")
		Destroy(gameObject);

		if(_coll.gameObject.tag == "LaserTag")
		{
		Destroy(gameObject);
		}
		
    }
		private void OnTriggerEnter2D( Collider2D _coll )
	{
		if ( _coll.gameObject.name == "ennemyDeadLine"|| _coll.gameObject.tag == "LaserTag" )
		{
			Destroy( gameObject );
		}
	}

    #endregion


    #region Private and Protected Members

    private float m_damage;

	#endregion

}
