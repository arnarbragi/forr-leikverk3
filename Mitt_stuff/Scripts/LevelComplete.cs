using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    //Fer með þig á Credits því að það er bara eitt borð
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Credits");
    }
}
