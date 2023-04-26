using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    public int index;
    public void LoadScene()
    {
        SceneManager.LoadScene(index);
    }
}
