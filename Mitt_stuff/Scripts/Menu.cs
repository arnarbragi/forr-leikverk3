using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //EF ýtt er á play þá load-ar þetta Main scene-ið
    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

    //EF ýtt er á Instructions þá load-ar þetta Instructions scene-ið
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    //EF ýtt er á Back þá load-ar þetta Menu scene-ið
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    //EF ýtt er á Quit þá lokar þetta forritinu
    public void QuitGame()
    {
        Application.Quit();
    }

}
