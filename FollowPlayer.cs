using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //tengjum myndavélina við spilaran
    public GameObject player;
    //breyta sem að stillir staðsettningu myndavélinar þannig að við sjáum í tankinn
    private Vector3 offset = new Vector3(0, 5, -7);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //notum LateUpdate() svo að tankurinn og myndavélin hreyfist í takt
    void LateUpdate()
    {
        //látum myndavélina fylgja eftir spilaranum (tankinum)
        transform.position = player.transform.position + offset;
    }
}
