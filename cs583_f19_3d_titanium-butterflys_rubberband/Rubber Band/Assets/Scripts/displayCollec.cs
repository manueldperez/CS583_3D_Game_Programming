using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class displayCollec : MonoBehaviour
{
    public GameObject collectablesText;
    private int collecFound;
    private int num;

    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == ("Instruction"))
        {
            num = 1;
            collectablesText.GetComponent<Text>().text = collecFound.ToString() + " / " + num.ToString();
        }
        if (scene.name == ("Level 1"))
        {
            num = 2;
            collectablesText.GetComponent<Text>().text = collecFound.ToString() + " / " + num.ToString();
        }
        if (scene.name == ("Level 2"))
        {
            num = 3;
            collectablesText.GetComponent<Text>().text = collecFound.ToString() + " / " + num.ToString();
        }
        if (scene.name == ("Level 3"))
        {
            num = 4;
            collectablesText.GetComponent<Text>().text = collecFound.ToString() + " / " + num.ToString();
        }
    }

    public void increase()
    {
        collecFound += 1;
    }

    public void output()
    {
        collectablesText.GetComponent<Text>().text = collecFound.ToString() + " / " + num.ToString();
    }
}