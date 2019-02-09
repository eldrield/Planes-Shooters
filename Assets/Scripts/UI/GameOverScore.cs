using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
	#region Public

	public GameObject m_scoreGameObject;

	#endregion


	#region System

	private void Awake()
	{
		m_score = PlayerPrefs.GetInt( "HighScore", 0 );
		m_scoreText = m_scoreGameObject.GetComponent<TextMeshProUGUI>();
	}
	private void Start()
	{
		m_scoreText.SetText( "{0}" , m_score );
	}

	#endregion


	#region Private

	private float m_score;
	private TextMeshProUGUI m_scoreText;

    #endregion

}
