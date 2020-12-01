using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject explosionFX;

    void OnTriggerEnter(Collider col)
    {
        FindObjectOfType<displayCollec>().increase();

        FindObjectOfType<displayCollec>().output();

        Instantiate(explosionFX, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
