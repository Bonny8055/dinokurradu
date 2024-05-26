using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public int level;
    void Start(){

    }
    public void OpenScene()
    {
        SceneManager.LoadScene("level " +level.ToString());
    }
}
