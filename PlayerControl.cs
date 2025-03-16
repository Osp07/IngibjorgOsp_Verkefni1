using UnityEngine;
//Ingibjörg Ösp - skrifta fyrir verkefni 1

public class PlayerControl : MonoBehaviour
{
    //Aðgengileg breyta sem að stjórnar hraðanum á tankinum
    private float speed = 20.0f;
    //aðgengileg breyta sem stjórnar hraðanum á snúningi
    private float turnSpeed = 20.0f;
    //aðgengileg breyta sem leyfir notanda að snúa tankinum
    private float horizontalInput;
    //aðgengileg breyta fyrir að færa tankinn fram og afturábak
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //breyta fyrir það þegar notandi notar takka til að fara til hægri og vinstri
        horizontalInput = Input.GetAxis("Horizontal");
        //breyta fyrir það þegar notandi notar takka til að fara fram og afturábak
        forwardInput = Input.GetAxis("Vertical");
        //tankurinn færist
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //tankurinn snýst
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
