using UnityEngine;

public class DoorController : MonoBehaviour
{
    //heldur utan um textann sem poppar upp hjá hurðinni
    public GameObject instructions;
    //reference á player collision script-ið
    private PlayerCollision collisionScript;

    private void Start()
    {
        collisionScript = GetComponent<PlayerCollision>();
    }

    //Þegar þú ert í triggerinum...
    private void OnTriggerStay(Collider other)
    {

        if(other.tag == "Door")
        {   
            //byrtir textann
            instructions.SetActive(true);

            if (collisionScript.doorLocked == false)
            {
                //ef ýtt er á E setur þetta í gang OpenClose animation-ið
                Animator anim = other.GetComponentInChildren<Animator>();
                if (Input.GetKeyDown(KeyCode.E))
                    anim.SetTrigger("OpenClose");
            }
        }
    }
    //Þegar þú ferð út úr triggerinum...
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Door")
        {
            //textinn hverfur
            instructions.SetActive(false);
        }
    }
}
