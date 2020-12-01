using UnityEngine;
using UnityEngine.UI;

public class displayTime : MonoBehaviour
{
    public GameObject display;
    public float time;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        int min = Mathf.FloorToInt(time / 60);
        int sec = Mathf.FloorToInt(time % 60);

        display.GetComponent<Text>().text = min.ToString("00") + ":" + sec.ToString("00");
    }
}
