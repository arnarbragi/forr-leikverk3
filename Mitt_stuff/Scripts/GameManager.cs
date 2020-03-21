using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject completeLevelUI;

    //Setur í gang completeLeveUI-ið sem tekur mann svo á næsta scene
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
