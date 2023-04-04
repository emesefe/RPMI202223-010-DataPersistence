using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{
    public void GoToScene(string sceneName) // Función que vamos a asignar a un botón
    {
        // Cargamos la escena por nombre
        SceneManager.LoadScene(sceneName);
    }
}
