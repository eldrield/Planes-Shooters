using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootTwo : MonoBehaviour 
{
	#region Public 

	[Header("Int")]
	public int m_numberOfSummon;
	public int m_fireCost;
	public int m_maxShoot;
	public int m_numberOfShoot;

	[Header("Float")]
	public float m_spriteRatioX;
	public float m_spriteRatioY;
	public float m_mdr;

	[Header("GOB")]
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
		m_maxShoot = GameObject.Find("SliderList").GetComponent<SliderPointList>().m_sliderList.Count;
		// m_numberOfShoot = 0;
    }
	private void Update()
	{

		m_numberOfPoint = gameObject.GetComponent<PlayerScore>().m_point;
		//--------------PC---------------//
		// if (Input.GetMouseButtonDown(0) && m_numberOfShoot > 0)
		// {
		// 	SummonBullet();
		// }
		//--------------TOUCH-----------//
		if (Input.touchCount > 1 && m_numberOfShoot > 0)
		{
			SummonBullet();
		}
	}

	#endregion


	#region Main

	public void SummonBullet()
	{

		if(m_numberOfShoot>0)
		{
			m_bulletXpos = m_spawnLimitLeft.transform.position.x;
			gameObject.GetComponent<PlayerScore>().ScoreDown();
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
	
    
    #endregion
}
