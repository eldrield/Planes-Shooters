using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsGenerator : MonoBehaviour
{
    #region Public Members

    

    #endregion


    #region System

    private void Awake()
    {
		m_mapManager = GameObject.Find( "MapsLimit" ).GetComponent<MapManager>();
		m_isInstantiate = false;
    }

    private void OnTriggerEnter2D( Collider2D _coll )
    {
        if ( _coll.gameObject.name == "MapsLimit" )
        {
            MapInstantiate();
        }
		if ( _coll.gameObject.name == "MapsEnd" )
            DestroyObject( gameObject );
    }
    
	#endregion
    
    
	#region Main

	private void MapInstantiate()
    {
		if ( !m_isInstantiate )
		{
			int i = Random.Range( 0 , m_mapManager.m_mapInfos.Count );
			float extents = gameObject.GetComponent<Collider2D>().bounds.extents.y*2;
			extents += m_mapManager.m_mapInfos[ i ].m_ground.GetComponent<Collider2D>().bounds.extents.y;
			float y = gameObject.transform.position.y;
			Vector3 mapPos = Vector3.zero;
			mapPos.y += extents;
			mapPos.y += y;
			Instantiate( m_mapManager.m_mapInfos[ i ].m_ground , mapPos , Quaternion.identity );
			m_isInstantiate = true;
		}
    }

    #endregion


    #region Private 

    private Transform m_transform;
	private MapManager m_mapManager;
    private Vector3 m_newMapsCoord;
	private bool m_isInstantiate;

    #endregion
}
