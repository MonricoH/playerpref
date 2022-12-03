using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   

    public void Scene2()
    {
        SceneManager.LoadScene("second");

    }
    public void Scene1()
    {
        SceneManager.LoadScene("first");

    }
    public void Scene3()
    {
        SceneManager.LoadScene("third");

    }
    public void Scenesound()
    {
        SceneManager.LoadScene("Sound");

    }
}
