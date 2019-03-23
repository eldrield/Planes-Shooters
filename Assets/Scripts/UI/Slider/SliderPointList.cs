using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class SliderList
{
	public Image m_slider;
}

public class SliderPointList : MonoBehaviour 
{
	#region Public

	public List<SliderList> m_sliderList;

	#endregion

	#region System

	private void Awake()
	{
		for (int i = 0; i < m_sliderList.Count; i++)
		{
			m_sliderList[i].m_slider.fillAmount = 0;
		}
	}

	#endregion
	
}
