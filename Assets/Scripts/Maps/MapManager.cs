using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MapInfos
{
    public string m_name;
    public GameObject m_ground;
    public float m_groundLength;
}

public class MapManager: MonoBehaviour
{
    #region Public Members

    public List<MapInfos> m_mapInfos;

    #endregion

}
