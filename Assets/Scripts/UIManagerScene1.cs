using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScene1 : MonoBehaviour
{
    public TMP_InputField inputField; // Referencia al inputField

    private string existingUsername;

    private const string USERNAME = "USERNAME";
    
    private void Start()
    {
        existingUsername = PlayerPrefs.GetString(USERNAME);
        if (existingUsername != "")
        {
            inputField.placeholder.GetComponent<TextMeshProUGUI>().text = existingUsername;
        }
    }

    public void SaveUsername() // Función que vamos a asignar a un botón
    {
        string inputText = inputField.text; // Tomamos el texto escrito en el inputField

        if (inputText == "") // Si el texto está vacío
        {
            // Guardamos en la variable username de DataPersistence el contenido del placeholder
            DataPersistence.sharedInstance.username =
                inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            // Si no, guardamos en la variable username el texto escrito en el inputField
            DataPersistence.sharedInstance.username = inputText;
        }
    }

    public void SaveUsernameWithPlayerPrefs()
    {
        PlayerPrefs.SetString(USERNAME, DataPersistence.sharedInstance.username);
    }
}
