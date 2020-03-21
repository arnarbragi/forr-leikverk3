using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public GameObject player;
    public Text healthText;
    int tempHealth = PlayerCollision.health;

    // Update is called once per frame
    void Update()
    {
        tempHealth = PlayerCollision.health;
        //Breyti texta á skjá
        healthText.text = "Lives: " + tempHealth.ToString();
    }
}
