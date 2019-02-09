using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string m_sceneName;
    public void GoToGame()
    {
        SceneManager.LoadScene( m_sceneName );
    }
    public void GoToGameScene()
    {
		Invoke( "GoToGame" , 1 );
       
    }
	public void GoToMainMenu()
	{
		Invoke( "GoToMain", 1 );
	}
	public void GoToMain()
	{
		SceneManager.LoadScene( "Menu" );
	}
}
