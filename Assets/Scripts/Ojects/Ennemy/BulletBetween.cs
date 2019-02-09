using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBetween : MonoBehaviour 
{
	#region Public

    public float m_speed;
	

    #endregion


    #region System

    private void Awake()
    {
		m_spawnLimitLeft = GameObject.Find("spawnLimitLeft");
		m_spawnLimitRight = GameObject.Find("spawnLimitRight");
        m_transform = gameObject.GetComponent<Transform>();
		if (Vector3.Distance(m_spawnLimitLeft.transform.position, gameObject.transform.position) > Vector3.Distance(m_spawnLimitRight.transform.position, gameObject.transform.position))
		{
			m_wereToGo = false;
		}
		else
		{
			m_wereToGo = true;
		}
    }

    private void Update()
    {
		if (m_wereToGo)
		{
		Vector2 movement = new Vector2( 1.5f , 0.6f );
        Vector2 position = m_transform.position;
        position -= movement * m_speed * Time.deltaTime;
        m_transform.position = position;
		}
		else if( !m_wereToGo)
		{
		Vector2 movement = new Vector2( -1.5f , 0.6f );
        Vector2 position = m_transform.position;
        position -= movement * m_speed * Time.deltaTime;
        m_transform.position = position;
		}
    }

	private void OnCollisionEnter2D( Collision2D _coll )
	{
			m_wereToGo = !m_wereToGo;
	}

    #endregion


    #region Private and Protected Members

	private bool m_wereToGo; // true = left false = right;
    private Transform m_transform;
	private GameObject m_spawnLimitLeft;
	private GameObject m_spawnLimitRight;

    #endregion
}
