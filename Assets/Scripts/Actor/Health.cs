using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    #region Public

	public float m_currentHealth;
    public float m_maxHealth;
    public int m_point;
	public GameObject m_explosion;

    #endregion


    #region System
    
    private void Awake()
    {
        m_currentHealth = m_maxHealth;
		m_Player = GameObject.Find( "Player" );
    }

    #endregion


    #region Main

    public void Hit( float _damage )
    {
        if ( gameObject.tag == "Player" )
        {
            m_currentHealth -= _damage;
			IsDead();
        }
        if ( gameObject.tag == "Ennemies" )
        {
            m_currentHealth -= _damage;
			IsDead();
        }
        if ( gameObject.tag == "Bullet" )
        {
            Destroy( gameObject );
        }
    }
    private void IsDead()
    {
        if ( gameObject.tag == "Player" && m_currentHealth <= 0 )
        {
			PlayerDead();
        }
		if ( gameObject.tag == "Ennemies" && m_currentHealth <= 0)
		{
			Instantiate( m_explosion , gameObject.transform.position , Quaternion.identity );
			Destroy( gameObject );
			m_Player.GetComponent<PlayerScore>().ScoreUp( m_point );
		}
    }
    private void PlayerDead()
	{
		Instantiate( m_explosion , gameObject.transform.position , Quaternion.identity );
		Destroy( gameObject );
		PlayerPrefs.SetInt( "HighScore" , m_Player.GetComponent<PlayerScore>().m_score );
		GoToScene();

	}
	private void GoToScene()
	{
		SceneManager.LoadScene( "GameOver" );
	}
    #endregion


    #region Private

	private GameObject m_Player;

    #endregion

}