using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_ : MonoBehaviour
{
    public void ToMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ToEndScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ToStartScene()
    {
        SceneManager.LoadScene(0);
    }

}
