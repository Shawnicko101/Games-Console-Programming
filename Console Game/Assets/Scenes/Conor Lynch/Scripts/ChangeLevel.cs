using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Conor's Level");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("David's Level");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Bens Level 2");
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("Marcin's Level");
    }

    public void LoadScene5()
    {
        SceneManager.LoadScene("Shawn's Level");
    }
}
