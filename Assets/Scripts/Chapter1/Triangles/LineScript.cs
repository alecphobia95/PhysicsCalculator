using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    public LineRenderer lr;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

}
