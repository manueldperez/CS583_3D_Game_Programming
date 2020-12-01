using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevels : MonoBehaviour
{

    void OnTriggerEnter(Collider x)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == ("Instruction"))
        {
            if (x.tag == "Player")
            {
                SceneManager.LoadScene("Menu");
            }
        }
        if (scene.name == ("Level 1"))
        {
            if (x.tag == "Player")
            {
                GameObject.Find("Score").GetComponent<HighScore>().CompletedLevel1(Mathf.FloorToInt(GameObject.Find("displayTime").GetComponent<displayTime>().time));
                SceneManager.LoadScene("Level 2");
            }
        }
        if (scene.name == ("Level 2"))
        {
            if (x.tag == "Player")
            {
                GameObject.Find("Score").GetComponent<HighScore>().CompletedLevel2(Mathf.FloorToInt(GameObject.Find("displayTime").GetComponent<displayTime>().time));
                SceneManager.LoadScene("Level 3");
            }
        }
    }
}