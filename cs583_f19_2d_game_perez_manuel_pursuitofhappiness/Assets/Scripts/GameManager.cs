using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public float slowness = 10f;
    public Button[] menu_buttons;

    public void EndGame()
    {
        StartCoroutine(menuPopUp());
    }

    IEnumerator menuPopUp()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        Time.timeScale = 0;

        FindObjectOfType<UI_Controller>().highScoreOutput();

        foreach (Button button in menu_buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
}