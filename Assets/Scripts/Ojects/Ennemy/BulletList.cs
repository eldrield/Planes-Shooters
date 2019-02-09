using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EnnemyBulletList
{
    public GameObject m_bullet;
    public int m_damage;
	
}
public class BulletList : MonoBehaviour 
{
	public List<EnnemyBulletList> m_bulletList;
}
