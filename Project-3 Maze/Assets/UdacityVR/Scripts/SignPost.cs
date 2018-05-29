using UnityEngine;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
       SceneManager.LoadSceneAsync("A Maze");
	}
}