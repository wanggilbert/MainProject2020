using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMenu : MonoBehaviour
{
    public string level;
    public string shebeijiangjie;
    public string yunweijianxiu;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            GoBackToMainMenu();
        }
    }

    void GoBackToMainMenu()
    {
        SceneManager.LoadScene(level);
    }

    public void SheBeiJiangJie()
    {
        SceneManager.LoadScene(shebeijiangjie);
    }

    public void YunWeiJianXiu()
    {
        SceneManager.LoadScene(yunweijianxiu);
    }
}
