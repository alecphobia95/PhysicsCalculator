using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneScript : MonoBehaviour
{
    public GameObject[] panels;
    private int panelPos = 0;

    private void Start()
    {
        ClearPanels();

    }

    private void ClearPanels()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
        panels[panelPos].SetActive(true);
    }
}
