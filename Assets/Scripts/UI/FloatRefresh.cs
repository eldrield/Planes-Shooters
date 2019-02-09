using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloatRefresh : PlayerScore
{
	#region Public

	public GameObject m_lifeGameObject;
	public GameObject m_scoreGameObject;
	public GameObject m_pointGameObject;

	#endregion


	#region System

	private void Awake()
	{
		m_textLifePointToResfresh = m_lifeGameObject.GetComponent<TextMeshProUGUI>();
		m_textScoreToRefresh = m_scoreGameObject.GetComponent<TextMeshProUGUI>();
		m_textPointToRefresh = m_pointGameObject.GetComponent<TextMeshProUGUI>();
	}

	private void Update()
    {
		m_floatScoreValue = gameObject.GetComponent<PlayerScore>().m_score;
        m_textScoreToRefresh.SetText( "Score : {0}" , m_floatScoreValue );
		m_floatPointValue = gameObject.GetComponent<PlayerScore>().m_point;
		m_textPointToRefresh.SetText( "Point : {0}" , m_floatPointValue );
		m_currentLifeValue = gameObject.GetComponent<Health>().m_currentHealth;
		m_textLifePointToResfresh.SetText( "Life : {0}" , m_currentLifeValue );
    }

	#endregion
    

	#region Private and Protected

	private float m_currentLifeValue;
    private float m_floatScoreValue;
	private float m_floatPointValue;

	private TextMeshProUGUI m_textLifePointToResfresh;
	private TextMeshProUGUI m_textScoreToRefresh;
	private TextMeshProUGUI m_textPointToRefresh;

    #endregion

}
