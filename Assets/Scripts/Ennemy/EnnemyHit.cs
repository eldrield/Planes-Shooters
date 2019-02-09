using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyHit : MonoBehaviour 
{   
    #region public

    public GameObject m_explosion;

    #endregion


	#region System

	private void Awake()
	{
		m_damage = 1;
	}
    
	private void OnCollisionEnter2D( Collision2D _coll )
    {
        if ( _coll.gameObject.tag == "Player" )
        {
            // gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
			_coll.gameObject.GetComponent<Health>().Hit( m_damage );
            Instantiate(m_explosion, gameObject.transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }

    #endregion


    #region Private and Protected Members

    private float m_damage;

    #endregion
}
