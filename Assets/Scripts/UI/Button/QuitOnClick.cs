using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{

    public void Quit()
    {
#if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false;
#else
        
#endif 
 if (Application.platform == RuntimePlatform.Android)
             {
                 Application.Quit();
             }

    }
}
