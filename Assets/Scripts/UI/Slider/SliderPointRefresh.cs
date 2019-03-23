using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SliderPointRefresh : MonoBehaviour 
{
	#region Public


	#endregion


	#region System

	private void Awake()
	{
		m_listGameobject = GameObject.Find("SliderList");
	}


	#endregion


	#region Main

	private float SliderValue( float _value, float _maxPointValue)
	{
		float Value = ((_value*100)/_maxPointValue)/100;
		return Value;
	}

	#endregion

	public void RefreshSprite(int _fireCost, int _actualPoint, int _numberOfShoot)
	{
		if (_numberOfShoot == m_listGameobject.GetComponent<SliderPointList>().m_sliderList.Count)
		{
			m_listGameobject.GetComponent<SliderPointList>().m_sliderList[_numberOfShoot-1].m_slider.fillAmount = 100;
		}else
		{
			float Value = SliderValue(_actualPoint, _fireCost);
			m_listGameobject.GetComponent<SliderPointList>().m_sliderList[_numberOfShoot].m_slider.fillAmount = Value;
		}
	}
	public void DownSliderSprite(int _fireCost, int _actualPoint, int _numberOfShoot)
	{
		float Value = SliderValue(_actualPoint, _fireCost);
		if (_numberOfShoot == m_listGameobject.GetComponent<SliderPointList>().m_sliderList.Count-1)
		{
			m_listGameobject.GetComponent<SliderPointList>().m_sliderList[_numberOfShoot].m_slider.fillAmount = Value;
		}else
		{
			m_listGameobject.GetComponent<SliderPointList>().m_sliderList[_numberOfShoot+1].m_slider.fillAmount = 0;
			m_listGameobject.GetComponent<SliderPointList>().m_sliderList[_numberOfShoot].m_slider.fillAmount = Value;	
		}
	}

	#region Private

	private GameObject m_listGameobject;
	private int m_numberOfShoot;

	private float m_point;

	#endregion

}
