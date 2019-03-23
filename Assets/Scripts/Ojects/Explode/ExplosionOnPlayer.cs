using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnPlayer : MonoBehaviour 
{
	#region Public

	public GameObject m_explode;

	#endregion


	#region System
	private void Awake()
	{
		m_player = GameObject.Find("Player");
	}

	#endregion


	#region Main 
	
	public void ExplodeOnPlayer()
	{
		if ( gameObject.transform.position.x > m_player.transform.position.x-0.05 && gameObject.transform.position.x < m_player.transform.position.x+0.05 )
		{
			if (gameObject.transform.position.y > m_player.transform.position.y)
			{
				InstantiateExplode(1);
			}
			else
			{
				InstantiateExplode(3);
			}
		}else if ( gameObject.transform.position.x < m_player.transform.position.x )
		{
			InstantiateExplode(2);
		}else
		{
			InstantiateExplode(0);
		}
	}
	private void InstantiateExplode(int _int)
	{
		Instantiate(m_explode, m_player.GetComponent<PlayerExplodeList>().m_explodeList[_int].m_explode.transform.position, Quaternion.identity);	
	}
	
	#endregion


	#region Private

	private GameObject m_player;

	#endregion
	
}
