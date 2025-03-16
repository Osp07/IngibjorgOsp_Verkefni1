using UnityEngine;
//Ingibjörg Ösp - leikmaður

public class PlayerController : MonoBehaviour
{
    //skilgreinum inputið
    public float horizontalInput;
    //skilgreinum hversu hratt leikmaðurinn getur farið, hægt að breyta tölunum í unity
    public float speed = 10.0f;
    //skilgreinum hversu langt leikmaðurinn getur farið til hliðanna, hægt er að breyta tölunum í unity
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //breyta fyrir það þegar notandi ýtir á takka til að fara til hliðanna
        horizontalInput = Input.GetAxis("Horizontal");
        //leikmaður færist til hliðanna
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //ef að leikmaður fer út fyrir staðsettningar mörkin sem eru sett fyrir færist hann á ystu mörk
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //ef að leikmaður fer út fyrir staðsettningar mörkin sem eru sett fyrir færist hann á ystu mörk
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //ef að leikmaður ýtir á bilstakka þá kemur banani inn á senuna á þeirri staðsettningu sem að leikmaðurinn er staddur
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
