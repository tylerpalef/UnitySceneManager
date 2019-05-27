using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventDestroy : MonoBehaviour
{
    private static PreventDestroy instanceRef;
    void Awake()
    {
        if (instanceRef == null) // If this game object is not found
        {
            instanceRef = this; // Create a reference that the script exists
            DontDestroyOnLoad(gameObject); // Don't destroy this game object as a result
        }
        else
        {
            DestroyImmediate(gameObject); // Destroy any duplicate gameobjects
        }

    }
}
