using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundry : MonoBehaviour
{
    public static float leftSide = -5.5f;
    public static float rightSide = 5.5f;
    public float internalLeft;
    public float internalRight;
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
        
    }
}
