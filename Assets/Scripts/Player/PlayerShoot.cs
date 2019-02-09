using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
	#region public

	public GameObject m_bullet;
	public GameObject m_canonTip;
	
	public GameObject m_ennemySpawner;

	#endregion


	#region System

	private void Start()
	{
		m_timeBetweenBullet = m_ennemySpawner.GetComponent<Spawner>().m_TimeBetweenSpawn;
		StartCoroutine( Shoot() );
	}

	private void Update()
	{
		// if ( Input.GetKeyUp( "space" ) )
		// {
		// 	Vector2 canonPos = new Vector2( m_canonTip.transform.position.x , m_canonTip.transform.position.y );
		// 	Instantiate( m_bullet , canonPos , Quaternion.identity );
		// }

		if (m_ennemySpawner.GetComponent<Spawner>().m_TimeBetweenSpawn < 0.41)
		{
		m_timeBetweenBullet = 0.20f;
		}
		else
		{
			m_timeBetweenBullet = m_ennemySpawner.GetComponent<Spawner>().m_TimeBetweenSpawn - 0.05f;
		}
	}
	#endregion

    
	#region Main

	public IEnumerator Shoot()
	{
		while ( true )
		{
			Vector2 canonPos = new Vector2( m_canonTip.transform.position.x , m_canonTip.transform.position.y );
			Instantiate( m_bullet , canonPos , Quaternion.identity );
			yield return new WaitForSeconds( m_timeBetweenBullet );
		}
	}


	#endregion

	#region Private

	private float m_timeBetweenBullet;

	#endregion
}
