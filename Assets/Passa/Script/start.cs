using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void Btnstart(string scene1)
    {
        SceneManager.LoadScene(scene1);
    }
    public void Btnexit()
    {
        Application.Quit();
    }
}
