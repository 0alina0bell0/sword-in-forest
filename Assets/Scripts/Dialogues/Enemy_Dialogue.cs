using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Dialogue : MonoBehaviour
{
    public GameObject panelDialog;
    public Text dialog;
    public string[] message;
    public bool dialogStart = false;

    void Start()
    {
        message[0] = "Прошу не трогай меня!Я сломал свой меч...";
        panelDialog.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panelDialog.SetActive(true);
            dialog.text = message[0];
            dialogStart = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        panelDialog.SetActive(false);
        dialogStart = false;

    }

}

