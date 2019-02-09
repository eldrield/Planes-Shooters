using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsMoove : MonoBehaviour
{
    #region public members

    public float m_speed;

    #endregion


    #region System

    private void Awake()
    {
        m_transform = gameObject.transform;
        m_vectorMove = new Vector3( 0 , 1 , 0 );
    }

    void Update()
    {
        m_transform.position -= m_vectorMove * m_speed * Time.deltaTime;
    }

    #endregion


    #region Main


    #endregion


    #region private

    private Transform m_transform;
    private Vector3 m_vectorMove;

    #endregion
}
