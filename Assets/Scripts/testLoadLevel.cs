using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testLoadLevel : MonoBehaviour
{

    public string level;
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene(level);
    }
}
