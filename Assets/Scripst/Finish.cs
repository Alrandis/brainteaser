using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private AssetBundle myLoadedAssetBundle;
    [SerializeField] private string scenePaths;
    private void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {   
            SceneManager.LoadScene(scenePaths, LoadSceneMode.Single); 
        }
    }

    // Устаревший тоже не рабочий скрипт
        //void OnTriggerEnter(Collider other)
        //{
        //    if (other.tag == "Player")
        //        if (Application.loadedLevel + 1 != Application.levelCount)
        //            Application.LoadLevel(Application.loadedLevel + 1);
        //        else
        //            Application.LoadLevel(0);
        //}
    
}
