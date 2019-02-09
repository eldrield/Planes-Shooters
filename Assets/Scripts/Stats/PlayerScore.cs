using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
	#region Public

	public int m_score;
	public int m_point;

	#endregion
   

	#region System

	private void Awake()
	{
		m_score = 0;
	}

	#endregion


	#region Main
    
	public void ScoreUp(int _scoreUp)
	{
		m_score += _scoreUp;
		m_point += _scoreUp;
	}

	public void ScoreDown(int _scoreDown)
	{
		m_point -= _scoreDown;
	}

	#endregion

}
