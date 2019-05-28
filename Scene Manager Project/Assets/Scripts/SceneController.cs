using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Required to be able to deal with scene names/build index
using UnityEngine.UI; // Required to display the scene number

public class SceneController : MonoBehaviour
{
	public KeyCode lastSceneKey; // Go back a scene key
	public KeyCode nextSceneKey; // Go forward a scene key 
    public Text sceneNumber; // Text to represent the scene number in the index
    private static SceneController instanceRef;


    // Awake is called sooner than Start.
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

        // Setting the values for the last and next scene keys.
        lastSceneKey = KeyCode.LeftArrow;
	    nextSceneKey = KeyCode.RightArrow;
        // DontDestroyOnLoad(this.gameObject);
    }

    // Update is called every frame 
    void Update()
    {
        int sceneNum = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Scene count in build is " + SceneManager.sceneCountInBuildSettings);
        Debug.Log("Scene num is " + sceneNum);

        // If input of last scene key, and scene number is greather than 0
        if (Input.GetKey(lastSceneKey) && sceneNum > 0)
        {
            // Confirming the input to go back a scene
            // Debug.Log("Last scene key has been pressed, proceeding to the previous scene, Scene # " + (sceneNum-1)); 
            // Add 1 to the current scene build index
            SceneManager.LoadScene((sceneNum - 1), LoadSceneMode.Single);
        }

        // If input of last scene key, and scene number is equal or less than 0
        if (Input.GetKey(lastSceneKey) && sceneNum <= 0)
        {
            // Confirming the input, however cannot go further back than 0 in the array.
            // Debug.Log("Last scene key has been pressed, go to last scene in build");
            SceneManager.LoadScene((SceneManager.sceneCountInBuildSettings - 1), LoadSceneMode.Single);
        }

        // If input of next scene key and scene number is equal or greather than 0
        if (Input.GetKey(nextSceneKey) && sceneNum >= 0 && sceneNum < SceneManager.sceneCountInBuildSettings)
        {
            // Confirming the input to the next scene
            // Debug.Log("Next scene key has been pressed, proceeding to the next scene, Scene # " + (sceneNum+1));
            // Add 1 to the current scene build index
            SceneManager.LoadScene((sceneNum + 1), LoadSceneMode.Single);
        }

        //If input of next scene key and the current scene is the last scene in the build index
        if (Input.GetKey(nextSceneKey) && (sceneNum + 1) == SceneManager.sceneCountInBuildSettings)
        {
            // Confirming the input to the next scene
            //Debug.Log("Next scene key has been pressed, going back to first scene");
            SceneManager.LoadScene((0), LoadSceneMode.Single);
        }

        // Update Scene Text
        sceneNumber.text = "Current Scene is " + sceneNum;
    }
 }
