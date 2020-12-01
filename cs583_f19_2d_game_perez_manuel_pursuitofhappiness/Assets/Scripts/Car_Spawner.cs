using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    public GameObject[] cars;
    private float timeToSpawn = 2f;
    public float timeBetweenWaves;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            float pos1 = Random.Range(-15.2f, 7f);

            Vector3 carPos = new Vector3(pos1, transform.position.y, transform.position.z);
            int car1 = Random.Range(0, 6);

            Instantiate(cars[car1], carPos, transform.rotation);
            
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }
}