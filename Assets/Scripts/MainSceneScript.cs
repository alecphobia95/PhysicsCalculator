using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneScript : MonoBehaviour
{
    public GameObject introPanel;
    public GameObject chapterHolderPanel;
    public CalculatorSelectionClass[] chapters;
    [Header("Buttons")]
    public GameObject playButtonObj;
    public GameObject previousButtonObj;
    public GameObject returnButtonObj;
    public GameObject nextButtonObj;
    public GameObject quitButtonObj;
    private Button playButton, previousButton, returnButton, nextButton, quitButton;
    private int chapterPos = 0;

    private void Start()
    {
        introPanel.SetActive(true);
        chapterHolderPanel.SetActive(false);
        SetButtons();
        SetChapterParameters();
    }

    private void ClearPanels()
    {
        previousButtonObj.SetActive(true);
        nextButtonObj.SetActive(true);
        for (int i = 0; i < chapters.Length; i++)
        {
            chapters[i].panel.SetActive(false);
        }
        if (chapterPos <= 0)
        {
            previousButtonObj.SetActive(false);
        }
        else if (chapterPos >= chapters.Length - 1)
        {
            nextButtonObj.SetActive(false);
        }
        chapters[chapterPos].panel.SetActive(true);
    }

    private void SetChapterParameters()
    {
        for (int i = 0; i < chapters.Length; i++)
        {
            chapters[i].SetParams();
        }
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
        previousButtonObj.SetActive(false);
        nextButtonObj.SetActive(true);
        introPanel.SetActive(false);
        chapterHolderPanel.SetActive(true);
        ClearPanels();
    }

    private void OnClickPrevious()
    {
        chapterPos--;

        ClearPanels();
    }

    private void OnClickReturn()
    {
        introPanel.SetActive(true);
        chapterHolderPanel.SetActive(false);
    }

    private void OnClickNext()
    {
        chapterPos++;

        ClearPanels();
    }

    private void OnClickQuit()
    {
        Application.Quit();
    }

}
