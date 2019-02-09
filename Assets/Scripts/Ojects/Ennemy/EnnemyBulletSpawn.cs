using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBulletSpawn : MonoBehaviour 
{
	#region Public

	public GameObject m_canonTip;

	public int m_wichBulletToSpawn;

	public float m_timeBetweenBullet;


	#endregion
	

	#region System

	void Awake()
	{
		m_player = GameObject.Find("Player");
	}
	private void Start()
	{
		Instantiate(m_player.GetComponent<BulletList>().m_bulletList[m_wichBulletToSpawn].m_bullet,m_canonTip.transform.position,Quaternion.identity);
		// StartCoroutine( Shoot());
	}

	#endregion
	
	#region Main

	public IEnumerator Shoot()
	{
		while ( true )
		{
			Vector2 canonPos = new Vector2( m_canonTip.transform.position.x , m_canonTip.transform.position.y );
			Instantiate(m_player.GetComponent<BulletList>().m_bulletList[m_wichBulletToSpawn].m_bullet,m_canonTip.transform.position,Quaternion.identity);
			yield return new WaitForSeconds( m_timeBetweenBullet );
		}
	}

	#endregion

	#region Private

	private GameObject m_player;

	#endregion
}
