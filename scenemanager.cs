using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Required to be able to deal with scene names/build index

public class scenemanager : MonoBehaviour
{
	public KeyCode lastSceneKey; // Go back a scene key
	public KeyCode nextSceneKey; // Go forward a scene key
// Awake is called sooner than Start.
   void Awake() 
   {
   	// Setting the values for the last and next scene keys.
	lastSceneKey = KeyCode.LeftArrow;
	nextSceneKey = KeyCode.RightArrow;


   	// sceneNum is the index of the scene from the "Scenes in Build"
   	 int sceneNum = SceneManager.GetActiveScene().buildIndex;
   }

// Update is called every frame 
   void Update()
   {
   	// If input of last scene key, and scene number is greather than 0
   	if(Input.GetKey(lastSceneKey) && sceneNum > 0)
   	{
   		// Confirming the input to go back a scene
   		Debug.Log("Last scene key has been pressed, proceeding to the previous scene"); 
   		// Add 1 to the current scene build index
   		SceneManager.LoadScene((sceneNum - 1), LoadSceneMode.Single); 
   	}

   	// If input of last scene key, and scene number is equal or less than 0
   	if(Input.GetKey(lastSceneKey) && sceneNum <= 0) 
   	{
   		 // Confirming the input, however cannot go further back than 0 in the array.
   		Debug.Log("Last scene key has been pressed, but the build index cannot go back");
   	}

   	// If input of next scene key and scene number is equal or greather than 0
   	if(Input.GetKey(nextSceneKey) && sceneNum >= 0) 
   	{
   		// Confirming the input to the next scene
   		Debug.Log("Next scene key has been pressed, proceeding to the next scene");
   		// Add 1 to the current scene build index
   		SceneManager.LoadScene((sceneNum + 1), LoadSceneMode.Single); 
   	}

   	// If input of next scene key and the current scene is the last scene in the build index
   	if(Input.GetKey(nextSceneKey) && sceneNum >= scene.buildIndex) 
   	{
   		// Confirming the input to the next scene
   		Debug.Log("Next scene key has been pressed, but the build index cannot go further");
   	}
  }
 }
