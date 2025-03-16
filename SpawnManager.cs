using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //listi sem hægt er að fylla út í unity fyrir þau dýr sem geta handahófskennt komið upp
    public GameObject[] animalPrefabs;
    //bilið á x ásnum sem að dýrin geta handahófskennt birst á
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    //seinkun á því hvenær dýrin byrja að byrtast
    private float strartDelay = 2;
    //tímamillibil á því hvenær dýr birtast
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2 sekúndur inn í leikin birtast dýrin inn í leikin á 1.5 sekúndna millibili
        InvokeRepeating("SpawnRandomAnimal", strartDelay, spawnInterval);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //staðsettningin sem að birtast er af handahófi innan skilgreindra marka á x ásnum
        Vector3 spawnPos =  new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            //tegund dýra sem að byrtast er af handahófi
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            //dýrin eru birt í leiknum
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
