using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadOne(){
        SceneManager.LoadScene(2);
    }

    public void LoadTwo(){
        SceneManager.LoadScene(3);
    }

    public void LoadThree(){
        SceneManager.LoadScene(4);
    }

    public void LoadFour(){
        SceneManager.LoadScene(5);
    }

    public void LoadFive(){
        SceneManager.LoadScene(6);
    }

}
