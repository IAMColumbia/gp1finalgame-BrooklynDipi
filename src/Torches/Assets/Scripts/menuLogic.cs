using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuLogic : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditsMenu;
    [SerializeField] GameObject levelSelect;
    [SerializeField] GameObject Torch;

    public void Awake()
    {
        Torch.SetActive(true);
        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
        levelSelect.SetActive(false);
    }

    public void ShowMainMenu()
    {
        Torch.SetActive(true);
        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
        levelSelect.SetActive(false);
    }

    public void ShowCreditsMenu()
    {
        Torch.SetActive(false);
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
        levelSelect.SetActive(false);
    }
    public void ShowLevelSelect()
    {
        Torch.SetActive(false);
        mainMenu.SetActive(false);
        creditsMenu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif  
    }
}
