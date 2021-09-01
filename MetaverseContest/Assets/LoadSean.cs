using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSean : MonoBehaviour
{
    public void OnClickScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
