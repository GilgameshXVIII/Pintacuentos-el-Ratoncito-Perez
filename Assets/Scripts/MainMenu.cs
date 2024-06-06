using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private static MainMenu _instance;
    public AudioSource initial_music;
    public static MainMenu Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public GameObject parentScene;
    public string DrawingPanel1;
    public string DrawingPanel2;
    public string DrawingPanel3;
    public void Scene0()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Scene1()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }
    public void Scene2()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
    }

    public void Scene3()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);
    }
    public void Scene4()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
    }
    public void Scene5()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(5, LoadSceneMode.Additive);
    }
    public void Scene6()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(6, LoadSceneMode.Additive);
    }
    public void Scene7()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(7, LoadSceneMode.Additive);
    }
    public void Scene8()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(8, LoadSceneMode.Additive);
    }
    public void Scene9()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(9, LoadSceneMode.Additive);
    }
    public void Scene10()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(10, LoadSceneMode.Additive);
    }
    public void Scene11()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(11, LoadSceneMode.Additive);
    }
    public void Scene12()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(12, LoadSceneMode.Additive);
    }
    public void Scene13()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(13, LoadSceneMode.Additive);
    }
    public void Scene14()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(14, LoadSceneMode.Additive);
    }
    public void Scene15()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(15, LoadSceneMode.Additive);
    }
    public void Scene16()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(16, LoadSceneMode.Additive);
    }
    public void Scene17()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(17, LoadSceneMode.Additive);
    }
    public void Scene18()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(18, LoadSceneMode.Additive);
    }
    public void Scene19()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(19, LoadSceneMode.Additive);
    }
    public void Scene20()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(20, LoadSceneMode.Additive);
    }
    public void Scene21()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(21, LoadSceneMode.Additive);
    }
    public void Scene22()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(22, LoadSceneMode.Additive);
    }
    public void Scene23()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(23, LoadSceneMode.Additive);
    }
    public void Scene24()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(24, LoadSceneMode.Additive);
    }
    public void Scene25()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(25, LoadSceneMode.Additive);
    }
    public void Scene26()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(26, LoadSceneMode.Additive);
    }
    public void Scene27()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(27, LoadSceneMode.Additive);
    }
    public void Scene28()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(28, LoadSceneMode.Additive);
    }
    public void Scene29()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(29, LoadSceneMode.Additive);
    }
    public void Scene30()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(30, LoadSceneMode.Additive);
    }
    public void Scene31()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(31, LoadSceneMode.Additive);
    }
    public void Scene32()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(32, LoadSceneMode.Additive);
    }
    public void Scene33()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(33, LoadSceneMode.Additive);
    }
    public void Scene34()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(34, LoadSceneMode.Additive);
    }
    public void Scene35()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(35, LoadSceneMode.Additive);
    }
    public void Scene36()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(36, LoadSceneMode.Additive);
    }
    public void Scene37()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(37, LoadSceneMode.Additive);
    }
    public void Scene38()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(38, LoadSceneMode.Additive);
    }
    public void Scene39()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(39, LoadSceneMode.Additive);
    }
    public void Scene40()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(40, LoadSceneMode.Additive);
    }
    public void Scene41()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(41, LoadSceneMode.Additive);
    }
    public void Scene42()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(42, LoadSceneMode.Additive);
    }
    public void Scene43()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(43, LoadSceneMode.Additive);
    }
    public void Scene44()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(44, LoadSceneMode.Additive);
    }
    public void Scene45()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(45, LoadSceneMode.Additive);
    }
    public void Scene46()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(46, LoadSceneMode.Additive);
    }
    public void Scene47()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(47, LoadSceneMode.Additive);
    }
    public void Scene48()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(48, LoadSceneMode.Additive);
    }
    public void Scene49()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(49, LoadSceneMode.Additive);
    }
    public void Scene50()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(50, LoadSceneMode.Additive);
    }
    public void Scene51()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(51, LoadSceneMode.Additive);
    }
    public void Scene52()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(52, LoadSceneMode.Additive);
    }
    public void Scene53()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(53, LoadSceneMode.Additive);
    }
    public void Scene54()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(54, LoadSceneMode.Additive);
    }
    public void Scene55()
    {
        parentScene.SetActive(false);
        SceneManager.LoadSceneAsync(55, LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
