using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneScript : MonoBehaviour
{
    public GameObject introPanel;
    public GameObject chapterHolderPanel;
    public GameObject[] chapterPanels;
    public GameObject playButtonObj, previousButtonObj, returnButtonObj, nextButtonObj, quitButtonObj;
    private Button playButton, previousButton, returnButton, nextButton, quitButton;
    private int chapterPos = 0;

    private void Start()
    {
        introPanel.SetActive(true);
        chapterHolderPanel.SetActive(false);
        SetButtons();
    }

    private void ClearPanels()
    {
        for (int i = 0; i < chapterPanels.Length; i++)
        {
            chapterPanels[i].SetActive(false);
        }
        chapterPanels[chapterPos].SetActive(true);
    }

    private void SetButtons()
    {
        playButton = playButtonObj.GetComponent<Button>();
        previousButton = previousButtonObj.GetComponent<Button>();
        returnButton = returnButtonObj.GetComponent<Button>();
        nextButton = nextButtonObj.GetComponent<Button>();
        quitButton = quitButtonObj.GetComponent<Button>();

        playButton.onClick.AddListener(OnClickStart);
        previousButton.onClick.AddListener(OnClickPrevious);
        returnButton.onClick.AddListener(OnClickReturn);
        nextButton.onClick.AddListener(OnClickNext);
        quitButton.onClick.AddListener(OnClickQuit);
    }

    private void OnClickStart()
    {
        chapterPos = 0;
        introPanel.SetActive(false);
        chapterHolderPanel.SetActive(true);
        ClearPanels();
    }

    private void OnClickPrevious()
    {
        chapterPos--;
        if(chapterPos <= 0)
        {
            previousButtonObj.SetActive(false);
        }
    }

    private void OnClickReturn()
    {
        introPanel.SetActive(true);
        chapterHolderPanel.SetActive(false);
    }

    private void OnClickNext()
    {
        chapterPos++;
        if (chapterPos >= chapterPanels.Length)
        {
            nextButtonObj.SetActive(false);
        }
    }

    private void OnClickQuit()
    {
        Application.Quit();
    }
}
