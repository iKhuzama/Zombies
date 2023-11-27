using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Play()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("Play");
    }

    public void Loading()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("Loading");
    }

    public void start()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("start");
    }

    public void Play2()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("Play2");
    }

    public void Levels()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("Levels");
    }

    
       /*    public void Loading()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("Loading");
    } */

    public void Loading2()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("Loading2");
    }

    public void Loading3()
    {
        // Code to handle the button click event
        Debug.Log("Button clicked!");

        // Load a new scene
        SceneManager.LoadScene("Loading3");
    }


}
