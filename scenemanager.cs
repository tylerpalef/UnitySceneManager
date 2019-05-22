using UnityEngine;
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

   }
 }
