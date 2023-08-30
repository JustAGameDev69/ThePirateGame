using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenupanel;
    public GameObject inforPanel;
    public bool isInforPanelActive = false;

    private void Awake()
    {
    }


    public void DeactivateStartMenu()
    {
        GameObject startMenu = GameObject.Find("StartMenu");
        if (startMenu != null)
        {
            startMenu.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    public void InforPanel()
    {
        inforPanel.SetActive(!inforPanel.activeSelf);
    }

    public void ShopButton()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void PlayerCostumeButton()
    {
        SceneManager.LoadScene("ChangePlayer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
