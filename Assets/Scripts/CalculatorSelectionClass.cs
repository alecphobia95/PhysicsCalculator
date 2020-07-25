using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class CalculatorSelectionClass
{
    public GameObject panel;
    public Dropdown selection;
    public Button calculateButton;
    public SceneAsset[] calculatorScenes;

    public void SetParams()
    {
        calculateButton.onClick.AddListener(OnClickCalculate);
        FillDropdown();
    }

    private void OnClickCalculate()
    {
        int sceneChoice = selection.value;
        if (sceneChoice >= calculatorScenes.Length)
        {
            Debug.LogError("You are trying to access a scene that has not been assigned");
        }
        else
        {
            SceneManager.LoadScene(calculatorScenes[sceneChoice].name);
        }
    }

    private void FillDropdown()
    {
        selection.ClearOptions();
        var options = new List<string>();
        for (int i = 0; i < calculatorScenes.Length; i++)
        {
            options.Add(calculatorScenes[i].name);
        }
        selection.AddOptions(options);
    }
}
