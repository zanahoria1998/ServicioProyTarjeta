//Código para hacer cambio de nivel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
