using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScene1 : MonoBehaviour
{
    public TMP_InputField InputField; // Referencia al InputField

    public void SaveUsername() // Función que vamos a asignar a un botón
    {
        string inputText = InputField.text; // Tomamos el texto escrito en el InputField

        if (inputText == "") // Si el texto está vacío
        {
            // Guardamos en la variable username de DataPersistence el contenido del placeholder
            DataPersistence.sharedInstance.username =
                InputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            // Si no, guardamos en la variable username el texto escrito en el InputField
            DataPersistence.sharedInstance.username = inputText;
        }
    }
}
