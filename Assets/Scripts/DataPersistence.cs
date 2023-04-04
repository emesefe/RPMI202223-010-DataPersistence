using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence sharedInstance; // Variable estática del mismo tipo que la clase


    public string username;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this); // Evitamos que el script se destruya tras cargar una nueva escena
        }
        else
        {
            Destroy(gameObject); // Destruimos todas las copias que haya de este script
        }
    }
}
