using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScreenController : MonoBehaviour
{
    public TMP_InputField txtUsuario;

    public void Login()
    {
        PlayerPrefs.SetString("username", txtUsuario.text);
        SceneManager.LoadScene("PrincipalScene");

    }

   
    void Update()
    {
        
    }
}
