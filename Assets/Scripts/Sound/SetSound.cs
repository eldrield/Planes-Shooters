using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetSound : MonoBehaviour 
{

	#region Public
	public AudioSource m_musicAudio;

	#endregion

	#region System

	private void Awake()
	{
		m_musicAudio.volume = PlayerPrefs.GetFloat( "ShootVol");
	}

	#endregion
}
