using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject ExitPanel;
    bool QuitOpen = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (QuitOpen == false)
            {
                QuitPanel();
            }
            else
            {
                MenuPanel();
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void QuitPanel()
    {
        ExitPanel.SetActive(true);
        QuitOpen = true;
    }

    public void MenuPanel()
    {
        ExitPanel.SetActive(false);
        QuitOpen = false;
    }
}
