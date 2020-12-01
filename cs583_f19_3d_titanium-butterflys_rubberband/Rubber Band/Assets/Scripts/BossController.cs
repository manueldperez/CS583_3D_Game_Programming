using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{

	GameObject button1, button2, button3;
	GameObject menuButton;
	GameObject win;
    public GameObject bossDeathFX;
    public GameObject bossDeathSFX;
    public GameObject bossDeathSFX2;

    bool notDropped;

    // Start is called before the first frame update
    void Start()
    {
        button1 = GameObject.Find("Button 1");
		button2 = GameObject.Find("Button 2");
		button3 = GameObject.Find("Button 3");
		menuButton = GameObject.Find("Menu");
		menuButton.SetActive(false);
		win = GameObject.Find("Win");
		win.SetActive(false);
		notDropped = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(button1.GetComponent<StageButtonController>().on && button2.GetComponent<StageButtonController>().on && button3.GetComponent<StageButtonController>().on && notDropped)
		{
			dropBoss();
		}
    }

	//when all buttons are pushed by the player 
	void dropBoss()
	{
        GameObject.Find("Score").GetComponent<HighScore>().CompletedLevel3(Mathf.FloorToInt(GameObject.Find("displayTime").GetComponent<displayTime>().time));

        notDropped = false;
		GetComponent<Rigidbody>().useGravity = true;
	}

	void OnCollisionEnter(Collision col)
	{
		//GAME OVER happens right here
		if(col.gameObject.name == "Player")
		{
            Instantiate(bossDeathFX, transform.position, Quaternion.identity);
            Instantiate(bossDeathSFX, transform.position, Quaternion.identity);
            Instantiate(bossDeathSFX2, transform.position, Quaternion.identity);

            Destroy(gameObject);
            menuButton.SetActive(true);
			win.SetActive(true);

		}
	}
}