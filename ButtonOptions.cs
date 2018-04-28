using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {

    //public void PlayGame()
    //{
   //     SceneManager.LoadScene(2);
   // }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    //here there are Track Selection Buttons


    public void Track01()
    {
        SceneManager.LoadScene(2);
    }
    public void Track02()
    {
        SceneManager.LoadScene(3);
    }
    public void Credits()
    {
        SceneManager.LoadScene(4);
    }
    public void GameQuit()
    {
        Application.Quit();
    }

}
