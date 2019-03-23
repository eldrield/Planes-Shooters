using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsSettings : MonoBehaviour {

    #region Public

    public Slider m_shootSlider;
    public Slider m_musicSlider;
	public AudioSource m_menuAudio;
	public AudioSource m_menuShoot;
    #endregion

    #region System

    private void Awake()
    {
        m_shootSlider.value = PlayerPrefs.GetFloat( "ShootVol" , 0.5f );
        m_musicSlider.value = PlayerPrefs.GetFloat( "MusicVol" , 0.5f );
    }

    void Update()
    {
        PlayerPrefs.SetFloat( "ShootVol" , m_shootSlider.value );
        PlayerPrefs.SetFloat( "MusicVol" , m_musicSlider.value );
		m_menuAudio.volume = PlayerPrefs.GetFloat( "MusicVol" , 0.5f );
		m_menuShoot.volume = PlayerPrefs.GetFloat( "ShootVol" , 0.5f );
    }


    #endregion
}
