using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enteruser : MonoBehaviour
{
    public InputField textBox;

    public void clickSave()
    {
        PlayerPrefs.SetString("username", textBox.text);
        SceneManager.LoadScene("third");
    }
}