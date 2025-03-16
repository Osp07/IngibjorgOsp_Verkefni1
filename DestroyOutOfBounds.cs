using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //skilgreinum svæði sem ekki má fara útfyrir
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ef að farið er yfir svæðið sem ekki má fara útfyrir er leikmuninum eytt
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //ef að farið er yfir svæðið sem ekki má fara útfyrir er leikmuninum eytt
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Leik Lokið!");
            Destroy(gameObject);
        }
    }
}
