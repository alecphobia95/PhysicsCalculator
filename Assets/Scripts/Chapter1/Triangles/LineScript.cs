using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScript : MonoBehaviour
{
    public LineRenderer lr;
    public InputField adjacentInput, oppositeInput, hypotenuseInput, thetaInput;
    [HideInInspector]
    public float adjacentFloat;
    [HideInInspector]
    public float oppositeFloat;
    [HideInInspector]
    public float hypotenuseFloat;
    [HideInInspector]
    public float thetaFloat;

}
