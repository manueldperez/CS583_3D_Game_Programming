using UnityEngine;

public class Destroyer: MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    void Update()
    {
        if (transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
    }
}