using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    //byrjar með 3 health
    static public int health = 3;
    public bool doorLocked = true;

    //Þegar þú labbar á hlut
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //Ef það er óvinur missir þú líf
        if (collisionInfo.collider.tag == "Enemy")
        {
            if (health > 1)
            {
                health -= 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (health == 1)
            {
                SceneManager.LoadScene("GameOver");
            }
            
        }
    }

    //Ef þú labbar í trigger...
    private void OnTriggerEnter(Collider other)
    {
        //Labbar á medkit..
        if(other.gameObject.CompareTag("Pick Up")) {
            //gefur þér 1 líf í viðbót
            health += 1;
            other.gameObject.SetActive(false);
        }

        //Labbar á lykil...
        if(other.gameObject.CompareTag("Key"))
        {
            //tekur hurðina úr lás
            doorLocked = false;
            other.gameObject.SetActive(false);
        }
    }

}
