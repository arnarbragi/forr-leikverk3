
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    //Ef þú labbar á triggerinn setur það í gang CompleteLEvel fallið hjá gameManager
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
