using UnityEngine;
//Ingibjörg Ösp - færum banana áfram

public class MoveForward : MonoBehaviour
{
    //skilgreinum hraðan sem er svo hægt að breyta í unity
    public float speed = 40.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //færum leikmunin áfram
        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }
}
