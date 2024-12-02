using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] TMP_InputField name;
    
    public void StartGame()
    {
        if (name.text != string.Empty)
        {
            SetPlayerName();
            SceneManager.LoadScene(1);
        }
    }

    public void SetPlayerName()
    {
        GameManager.Instance.PlayerName = name.text;
    }
}
