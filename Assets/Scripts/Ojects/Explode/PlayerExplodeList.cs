using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ExplodeList
{
	public string m_name;
	public GameObject m_explode;
}
public class PlayerExplodeList : MonoBehaviour 
{
	public List<ExplodeList> m_explodeList;

}
