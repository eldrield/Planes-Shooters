using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Ennemy
{
    public GameObject m_ennemy;
	
}
public class Spawner : MonoBehaviour
{
	#region Public Members

	public List<Ennemy> m_ennemyList;

	[Header("Float")]
	public float m_increaseSpanwnTime;
	public float m_TimeBetweenSpawn;

	[Header("GOB")]
	public GameObject m_prefabEnnemy;
	public GameObject m_spawnLimitLeft;
	public GameObject m_spawnLimitRight;

	#endregion


	#region Main
    

	private void Awake()
	{
		m_startTime = Time.time;
	}
	public IEnumerator EnnemySpawner()
	{
		while ( true )
		{
			if ( m_TimeBetweenSpawn > 0.40)
			{         
			Vector2 ennemyPos = new Vector2( UnityEngine.Random.Range( m_limitLeft , m_limitRight ) , m_limitUp );
			Instantiate( m_prefabEnnemy , ennemyPos , Quaternion.identity );
			yield return new WaitForSeconds( m_TimeBetweenSpawn );
        	}
			else
		 	{
				 if( Time.time - m_startTime < 90)
				 {
					 int _wichToSpawn = UnityEngine.Random.Range(0,2);
					Vector2 ennemyPos = new Vector2( UnityEngine.Random.Range( m_limitLeft , m_limitRight ) , m_limitUp );
					Instantiate( m_ennemyList[_wichToSpawn].m_ennemy , ennemyPos , Quaternion.identity );
					yield return new WaitForSeconds( m_TimeBetweenSpawn );
				 }
				 else
				 {
					int _wichToSpawn = UnityEngine.Random.Range(0,m_ennemyList.Count);
					Vector2 ennemyPos = new Vector2( UnityEngine.Random.Range( m_limitLeft , m_limitRight ) , m_limitUp );
					Instantiate( m_ennemyList[_wichToSpawn].m_ennemy , ennemyPos , Quaternion.identity );
					yield return new WaitForSeconds( m_TimeBetweenSpawn );		 
				 }
			}
		}
	}

	#endregion

	#region System

	private void Start()
	{
		m_limitUp = m_spawnLimitRight.transform.position.y;
		m_limitRight = m_spawnLimitRight.transform.position.x;
		m_limitLeft = m_spawnLimitLeft.transform.position.x;

		StartCoroutine( EnnemySpawner() );

	}
	private void Update()
	{
		if ( m_TimeBetweenSpawn > 0.40)
		{
			m_TimeBetweenSpawn -= m_increaseSpanwnTime * Time.deltaTime;         
        }

	}

	#endregion


	#region private

	private float m_startTime;
	private float m_limitLeft;
	private float m_limitRight;
	private float m_limitUp;

    #endregion
}

