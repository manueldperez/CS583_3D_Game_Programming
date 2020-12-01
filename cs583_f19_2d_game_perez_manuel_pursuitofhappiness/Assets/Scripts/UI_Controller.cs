using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
	public Text scoreText;
    public Text highScoreText;
	int score;

    // Start is called before the first frame update
    void Start()
    {
		score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
		Scene scene = SceneManager.GetActiveScene();
		if (scene.name == ("game_scene"))
		{
			scoreText.text = "Score: " + score;
		}
    }

    void scoreUpdate()
	{
	    score += 1;
	}

    public void highScoreOutput()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "HighScore: " + score;
        }
        else
        {
            highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0);
        }
    }

	public void Play()
	{
        SceneManager.LoadScene("game_scene");
        Time.timeScale = 1f;
    }

    public void Instructions()
	{
		SceneManager.LoadScene("instructions_scene");
	}

    public void MainMenu()
	{
		SceneManager.LoadScene("menu_scene");
	}

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void Credits()
    {
        SceneManager.LoadScene("credits_scene");
    }

    public void QuitGame()
    {
        PlayerPrefs.DeleteKey("HighScore");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Debug.Log("Quit the game");
    Application.Quit();

#endif
    }
}