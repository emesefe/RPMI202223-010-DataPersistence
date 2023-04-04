using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScene2 : MonoBehaviour
{
    public TextMeshProUGUI helloText;

    private void Start()
    {
        // Mostramos en el texto TMPro el contenido de la variable username de DataPersistence
        helloText.text = $"Hello, {DataPersistence.sharedInstance.username}";
    }
}
