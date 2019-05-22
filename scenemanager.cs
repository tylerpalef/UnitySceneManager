using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Required to be able to deal with scene names/build index

public class scenemanager : MonoBehaviour
{
// Awake is called sooner than Start.
   void Awake() 
   {
   	// sceneNum is the index of the scene from the "Scenes in Build"
   	 int sceneNum = SceneManager.GetActiveScene().buildIndex;
   }

// Update is called every frame 
   void Update()
   {
   	if(Input.GetKey("left") && sceneNum > 0) // If input of left arrow, and scene number is greather than 0
   	{
   		Debug.Log("Left arrow has been pressed"); // Confirming the input to go back a scene
   		SceneManager.LoadScene((sceneNum - 1), LoadSceneMode.Single); // Subtract 1 from the current 
   	}

   	if(Input.GetKey("left") && sceneNum <= 0) // If input of left arrow, and scene number is equal or less than 0
   	{
   		Debug.Log("Left arrow has been pressed, but the build index cannot go back"); // Confirming the input, however cannot go further back than 0 in the array.
   	}



   }
 }
