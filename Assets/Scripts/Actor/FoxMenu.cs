using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMenu : MonoBehaviour
{
	#region Public

	public float m_speed;
	public bool m_go;

	#endregion


	#region System

	private void Awake()
    {
        m_speed = 0;
        m_transform = gameObject.GetComponent<Transform>();
		m_go = false;
    }

    private void Update()
    {
		
        Vector2 movement = new Vector2( 0f , m_speed );
        Vector2 position = m_transform.position;
        position += movement * m_speed * Time.deltaTime;
        m_transform.position = position;
    }

	#endregion


	#region Main

    public void Go()
	{
		m_speed = 3.3f;
	}

	#endregion

	#region Private

	private Transform m_transform;

	#endregion

}
