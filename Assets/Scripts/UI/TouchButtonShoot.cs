using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchButtonShoot : MonoBehaviour 
{
	#region Public

	public GameObject m_player;

	#endregion

	#region System

	private void Awake()
	{
		m_transform = GetComponent<Transform>();	
	}
	 private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

   if(touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
         {
            //  Ray CursorRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position );
			//  RaycastHit Hit;
            //  if(Physics.Raycast( CursorRay , Hit, 1000.0f ) )
            //  {
            //      if(Hit.transform.tag == "Objects")
            //      { TargetAhead = GameObject.Find(Hit.transform.name); }
            //      else { TargetAhead = GameObject.Find("Ground"); }
            //  }
			RaycastHit Hit;
			if(Physics.Raycast(Input.GetTouch(0).position , m_transform.TransformDirection(Vector3.forward) , out Hit ,  Mathf.Infinity, 5))
			{
				if(Hit.transform.tag == "UIButton")
				{
					m_player.GetComponent<PlayerShootTwo>().SummonBullet();
				}
			}
         }
		}
	}

	#endregion

	#region Private

	private Transform m_transform;

	#endregion
}
