using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapValues
{

    // Maps a value from ome arbitrary range to another arbitrary range
    // Ex: map(60, 50, 150, 0, 1); returns a value between 0 and 1. 
    public static float map(float value, float leftMin, float leftMax, float rightMin, float rightMax)
    {
        float val = rightMin + (value - leftMin) * (rightMax - rightMin) / (leftMax - leftMin);
        Debug.Log(val);
        return val;
    }

}
