using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    #region Public Members

    public float m_speed;
    

    #endregion


    #region System

    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
        m_transform = GetComponent<Transform>();
		m_playerAnimator = GetComponent<Animator>();
        m_lastTouch = m_transform.position;
        Cursor.visible = false;
        // m_width = (float)Screen.width / 2.0f;
        // m_width = Screen.width; 
    }

    #endregion


    private void Update()
    {
        // if (Input.touchCount > 0)
        // {
            // m_lastTouch = Camera.main.ScreenToWorldPoint(new Vector3 (Input.GetTouch(0).position.x, m_transform.position.y, m_transform.position.z));
            // Touch touch = Input.GetTouch(0);
            // if (touch.phase == TouchPhase.Moved)
            // {
            //     Vector2 pos = touch.position;
            //     pos.x = (pos.x - m_width) / m_width;
          
            //     Vector2 position = new Vector2(pos.x, m_transform.position.y);

            //     m_transform.position = position;
     
            // }
        // }
        // m_transform.position = m_lastTouch;
		// Vector2 movement = new Vector2( Input.GetAxisRaw( "Horizontal" ) , Input.GetAxisRaw("Vertical") );
		// if ( Input.GetAxisRaw( "Horizontal" ) == 0 )
		// {
		// 	m_rigidbody.velocity = Vector2.zero;
		// }else 
		// {
		// 	m_rigidbody.AddForce( movement * m_speed );         
        // }
		// if (Input.GetAxisRaw("Horizontal")< 0)
		// {
		// 	m_playerAnimator.SetBool( "isLeft" , true );
		// }
		// else
		// {
		// 	m_playerAnimator.SetBool( "isLeft" , false );
		// }
		// if ( Input.GetAxisRaw( "Horizontal" ) > 0 )
        // {
        //     m_playerAnimator.SetBool( "isRight" , true );
        // }
        // else
        // {
        //     m_playerAnimator.SetBool( "isRight" , false );
        // }
        
        
    }
    private void LateUpdate() 
    {
      if (Input.touchCount > 0)
        {
            //     RaycastHit hit;
            //     Ray ray = Camera.main.ScreenPointToRay(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position));
            //    if(Physics.Raycast( ray ,m_transform.TransformDirection(Vector3.forward), out hit , Mathf.Infinity, 9))
            //     if( Physics.Raycast( new Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y, 9f), m_transform.TransformDirection(Vector3.forward) ,out hit, Mathf.Infinity) && hit.collider.tag == "Player")
            //     {
                    // dragging = true;
                    m_lastTouch = Camera.main.ScreenToWorldPoint(new Vector3 (Input.GetTouch(0).position.x, Input.GetTouch(0).position.y , 9f));
                // }
        }
        m_transform.position = m_lastTouch;
            //-----------PC/MAC moove-------------//
        // Vector3 mouseScreenPosition = Input.mousePosition;
        // Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        // mouseWorldSpace.z = 9f;
        // m_transform.position = mouseWorldSpace;

    }

    #region Main

    public void MooveLeft()
    {
        // Vector2 movement = new Vector2( -1, 0f ) ;
        // m_rigidbody.AddForce(movement * m_speed *2);
        // Debug.Log("sa pue");
    }
    //   public void MooveRight()
    // {
    //     Vector2 movement = new Vector2( 1, 0f ) ;
    //     m_rigidbody.AddForce(movement * m_speed *2);
    // }

    #endregion

	#region Privates and Protected Members

	private Animator m_playerAnimator;
    private Rigidbody2D m_rigidbody;
    private Transform m_transform;
    // private float m_width;

    private Vector3 m_lastTouch;

    #endregion

               //       if ( pos.x - m_transform.position.x > 0)
                // {
                //     m_playerAnimator.SetBool( "isRight" , true );
                // }
                // else if (pos.x - m_transform.position.x < 0)
                // {
                //     m_playerAnimator.SetBool( "isLeft" , true );
                // }
                // else
                // {
                //     m_playerAnimator.SetBool( "isRight" , false );
                //     m_playerAnimator.SetBool( "isRight" , false );
                // }
}
