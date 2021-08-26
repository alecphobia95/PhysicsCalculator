using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScript : MonoBehaviour
{
    public LineRenderer lr;
    [Header("Inputs")]
    public InputField adjacentInput;
    public InputField oppositeInput;
    public InputField hypotenuseInput;
    public InputField thetaInput;
    [Header("Buttons")]
    public Button adjacentButton;
    public Button oppositeButton;
    public Button hypotenuseButton;
    public Button thetaButton;
    public Button calculateButton;
    public Button resetButton;
    public Button adjacentExcludeButton;
    public Button oppositeExcludeButton;
    public Button hypotenuseExcludeButton;
    public Button thetaExcludeButton;
    [Header("Text")]
    public Text feedbackText;
    [HideInInspector]
    public float adjacentFloat;
    [HideInInspector]
    public float oppositeFloat;
    [HideInInspector]
    public float hypotenuseFloat;
    [HideInInspector]
    public float thetaFloat;

    private int target, exclude;
    private Button[] calcButtons = new Button[4];
    private Button[] excludeButtons = new Button[4];
    private InputField[] inputs = new InputField[4];


    private void Start()
    {
        calcButtons[0] = adjacentButton;
        calcButtons[1] = oppositeButton;
        calcButtons[2] = hypotenuseButton;
        calcButtons[3] = thetaButton;

        excludeButtons[0] = adjacentExcludeButton;
        excludeButtons[1] = oppositeExcludeButton;
        excludeButtons[2] = hypotenuseExcludeButton;
        excludeButtons[3] = thetaExcludeButton;

        inputs[0] = adjacentInput;
        inputs[1] = oppositeInput;
        inputs[2] = hypotenuseInput;
        inputs[3] = thetaInput;

        OnClickReset();

    }

    public void OnClickAdjacentCalc()
    {
        DisableButtons(calcButtons);
        EnableButtons(excludeButtons);
        adjacentExcludeButton.interactable = false;
    }

    public void OnClickOppositeCalc()
    {
        DisableButtons(calcButtons);
        EnableButtons(excludeButtons);
        oppositeExcludeButton.interactable = false;
    }

    public void OnClickHypotenuseCalc()
    {
        DisableButtons(calcButtons);
        EnableButtons(excludeButtons);
        hypotenuseExcludeButton.interactable = false;
    }


    public void OnClickThetaCalc()
    {
        DisableButtons(calcButtons);
        EnableButtons(excludeButtons);
        thetaExcludeButton.interactable = false;
    }

    public void OnClickExclude()
    {
        DisableButtons(excludeButtons);
        CheckReadyForInputs();
    }

    private void OnClickCalculate()
    {
        bool calcSelected = IsThisSelected(calcButtons);
        bool excludeSelected = IsThisSelected(excludeButtons);

        if((calcSelected == true) && (excludeSelected == true))
        {
            WhatToSolveFor();
        }

        else
        {
            Debug.LogError("How did you fail to get this set up, it's so easy man");
        }

    }

    public void OnClickReset()
    {
        EnableButtons(calcButtons);

        DisableButtons(excludeButtons);

        for (int x = 0; x < inputs.Length; x++)
        {
            inputs[x].text = "";
            inputs[x].interactable = false;
        }

        target = -1;
        exclude = -1;

        calculateButton.interactable = false;
        resetButton.interactable = false;

        feedbackText.text = "Press O to choose what to calculate and X to choose what to leave out";
    }

    private bool IsThisSelected(Button[] checkFor)
    {
        bool selected = false;
        for(int x = 0; x < checkFor.Length; x++)
        {
            if(checkFor[x].interactable == false)
            {
                selected = true;
                if(target == -1)
                {
                    target = x;
                }
                else
                {
                    exclude = x;
                }
            }
        }
        return (selected);
    }

    private void DisableButtons(Button[] toDisable)
    {
        for (int x = 0; x < toDisable.Length; x++)
        {
            toDisable[x].interactable = false;
        }

        resetButton.interactable = true;
    }

    private void EnableButtons(Button[] toEnable)
    {
        for (int x = 0; x < toEnable.Length; x++)
        {
            toEnable[x].interactable = true;
        }
    }

    private void CheckReadyForInputs()
    {
        bool calcSelected = IsThisSelected(calcButtons);
        bool excludeSelected = IsThisSelected(excludeButtons);

        if ((calcSelected == true) && (excludeSelected == true))
        {
            for (int x = 0; x < calcButtons.Length; x++)
            {
                if((x != target) && (x != exclude))
                {
                    inputs[x].interactable = true;
                }
            }

            calculateButton.interactable = true;
        }
    }

    private bool InputsFilled()
    {
        bool filled = true;

        for (int x = 0; x < inputs.Length; x++)
        {
            if ((x != target) && (x != exclude))
            {
                if(inputs[x].text == "")
                {
                    filled = false;
                }
            }
        }

        return (filled);
    }

    private void WhatToSolveFor()
    {
        if (InputsFilled())
        {

        }

        else
        {

        }
    }

}
