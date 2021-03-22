using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public void ChangeSceneA()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeSceneB()
    {
        SceneManager.LoadScene("02NumberScene");
     
    }
    
    public void ChangeSceneC()
    {
        SceneManager.LoadScene("00WelcomeScene");
     
    }
}
