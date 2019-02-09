using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class GetSounds : MonoBehaviour 
{
	#region Public

	public AudioSource m_musicAudio;
	 public AudioMixerGroup m_shootGroup;

	#endregion

	#region System

	private void Awake()
	{
		m_musicAudio.volume = PlayerPrefs.GetFloat( "MusicVol");
		m_shootGroup.audioMixer.SetFloat( "Volume" , PlayerPrefs.GetFloat( "ShootVol" ));
	}

	#endregion
}
