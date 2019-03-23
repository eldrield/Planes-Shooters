using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerScore : MonoBehaviour
{
	#region Public

	[Header("Int")]
	public int m_score;
	public int m_point;
	[Header("GOB")]
	public GameObject m_sliderPointGob;

	#endregion
   

	#region System

	private void Awake()
	{
		m_score = 0;
		// m_sliderPointList = GameObject.Find("SliderList");
		m_playerShootTwo = GameObject.Find("Player").GetComponent<PlayerShootTwo>();
	}

	#endregion


	#region Main
    
	public void ScoreUp(int _scoreUp)
	{
		m_score += _scoreUp;
		if (m_point+_scoreUp < m_playerShootTwo.m_fireCost)
		{
			m_point += _scoreUp;
			RefreshUI();

		}else 
		{
			if ( m_playerShootTwo.m_maxShoot >= m_playerShootTwo.m_numberOfShoot+1)
			{
				if (m_playerShootTwo.m_numberOfShoot == m_sliderPointGob.GetComponent<SliderPointList>().m_sliderList.Count)
				{
					m_point = 0;
				}
				else 
				{
					m_playerShootTwo.m_numberOfShoot+=1;
					m_point = 0;
				}
			}
		}
		
		// Debug.Log(m_point);
		// Debug.Log(GameObject.Find("Player").GetComponent<PlayerShootTwo>().m_numberOfShoot);
		// Debug.Log(GameObject.Find("Player").GetComponent<PlayerShootTwo>().m_maxShoot);
	}

	public void ScoreDown()
	{
		m_playerShootTwo.m_numberOfShoot-=1;
		m_sliderPointGob.GetComponent<SliderPointRefresh>().DownSliderSprite(m_playerShootTwo.m_fireCost, m_point, m_playerShootTwo.m_numberOfShoot);
	}
	private void RefreshUI()
	{
		m_sliderPointGob.GetComponent<SliderPointRefresh>().RefreshSprite(m_playerShootTwo.m_fireCost, m_point, m_playerShootTwo.m_numberOfShoot);
	}

	#endregion

	#region Private

	private PlayerShootTwo m_playerShootTwo;	

	#endregion

}
