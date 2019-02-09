using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootTwo : MonoBehaviour 
{
	#region Public 

	public int m_numberOfSummon;

	public float m_spriteRatioX;
	public float m_spriteRatioY;
	public float m_mdr;

    //GameObject
	public GameObject m_canonTip;
	public GameObject m_bullet;

	public GameObject m_spawnLimitLeft;
	public GameObject m_spawnLimitRight;

    #endregion


    #region System

    private void Awake()
    {      
		m_screenWidth = m_spawnLimitRight.transform.position.x - m_spawnLimitLeft.transform.position.x;
		m_summonWidth = m_screenWidth / m_numberOfSummon;
		m_canonPos = m_canonTip.transform.position.y;
		m_mdr = Vector2.Distance( m_spawnLimitLeft.transform.position , m_spawnLimitRight.transform.position);
		m_fireCost = 4000;
    }
	private void Update()
	{
		m_numberOfPoint = gameObject.GetComponent<PlayerScore>().m_point;
		if (Input.GetMouseButtonDown(0) && m_numberOfPoint > m_fireCost)
		{
			SummonBullet();
		}
	}

	#endregion


	#region Main

	public void SummonBullet()
	{
		if(m_numberOfPoint > m_fireCost)
		{
			m_bulletXpos = m_spawnLimitLeft.transform.position.x;
			gameObject.GetComponent<PlayerScore>().ScoreDown(m_fireCost);
			for ( int i = 0 ; i <= m_numberOfSummon ; i++)
			{
				Vector2 bulletPos = new Vector2(m_bulletXpos, m_canonPos);
				Instantiate( m_bullet , bulletPos , Quaternion.identity );
				m_bulletXpos += m_summonWidth;
			}
		}
		
	}

	#endregion


	#region Private and Protected Members

	private float m_screenWidth;

	private float m_summonWidth;
	private float m_summonHeight;

	private float m_canonPos;

	private float m_screenWidthSize;
	private float m_bulletXpos;

	private Vector2 m_spriteSize;

	private int m_numberOfPoint;
	private int m_fireCost;
    
    #endregion
}
