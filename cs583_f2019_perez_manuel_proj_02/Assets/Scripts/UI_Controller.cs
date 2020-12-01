using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public Player_State Player;

    public GameObject pName;
    public GameObject speedW;
    public GameObject speedR;
    public GameObject speedJ;
    public GameObject expP;
    public GameObject hitP;
    public GameObject armorC;

    public Dropdown race;
    public Dropdown Class;
    public Dropdown alignment;
    public Dropdown ability_dropdown;

    public GameObject firstRoll;
    public GameObject secondRoll;
    public GameObject thirdRoll;
    public GameObject fourthRoll;
    public GameObject fifthRoll;

    public InputField firstBox;
    public InputField secondBox;
    public InputField thirdBox;
    public InputField fourthBox;
    public InputField fifthBox;

    public GameObject displayStrength;
    public GameObject displayDexterity;
    public GameObject displayConstitution;
    public GameObject displayIntelligence;
    public GameObject displayWisdom;
    public GameObject displayCharisma;

    public InputField disBoxOne;
    public InputField disBoxTwo;
    public InputField disBoxThree;
    public InputField disBoxFour;
    public InputField disBoxFive;
    public InputField disBoxSix;

    public GameObject Save_B;
    public InputField save;

    public GameObject jsonOut;
    public InputField jOutput;

    public Button jsonn;
    public Button dicee;
    public Button save_buttonn;
    public Button button_Quitt;
    public Button menuu;
    public Button createChar;

    public int roll1;
    public int roll2;
    public int roll3;
    public int roll4;
    public int roll5;

    public int max;

    public void Awake()
    {
        pName = GameObject.Find("NAME");
        speedW = GameObject.Find("Walking");
        speedR = GameObject.Find("Running");
        speedJ = GameObject.Find("Jumping");

        expP = GameObject.Find("Experience Points");
        hitP = GameObject.Find("Hit Points");
        armorC = GameObject.Find("Armor Class");

        race = GameObject.Find("Races").GetComponent<Dropdown>();
        Class = GameObject.Find("Classes").GetComponent<Dropdown>();
        alignment = GameObject.Find("Alignments").GetComponent<Dropdown>();

        firstRoll = GameObject.Find("1st Roll");
        secondRoll = GameObject.Find("2nd Roll");
        thirdRoll = GameObject.Find("3rd Roll");
        fourthRoll = GameObject.Find("4th Roll");
        fifthRoll = GameObject.Find("5th Roll");

        firstBox = firstRoll.GetComponent<InputField>();
        secondBox = secondRoll.GetComponent<InputField>();
        thirdBox = thirdRoll.GetComponent<InputField>();
        fourthBox = fourthRoll.GetComponent<InputField>();
        fifthBox = fifthRoll.GetComponent<InputField>();

        ability_dropdown = (Dropdown) GameObject.Find("Ability_DICE").GetComponent<Dropdown>();

        Save_B = GameObject.Find("Save_Button");
        save = Save_B.GetComponent<InputField>();

        Player = new Player_State();

        displayStrength = GameObject.Find("Strength");
        displayDexterity = GameObject.Find("Dexterity");
        displayConstitution = GameObject.Find("Constitution");
        displayIntelligence = GameObject.Find("Intelligence");
        displayWisdom = GameObject.Find("Wisdom");
        displayCharisma = GameObject.Find("Charisma");

        disBoxOne = displayStrength.GetComponent<InputField>();
        
        disBoxTwo = displayDexterity.GetComponent<InputField>();
        disBoxThree = displayConstitution.GetComponent<InputField>();
        disBoxFour = displayIntelligence.GetComponent<InputField>();
        disBoxFive = displayWisdom.GetComponent<InputField>();
        disBoxSix = displayCharisma.GetComponent<InputField>();

        jsonOut = GameObject.Find("JSON output");
        jOutput = jsonOut.GetComponent<InputField>();

        dicee = GameObject.Find("DICE").GetComponent<Button>();
        dicee.onClick.AddListener(Roll_Dice);

        save_buttonn = GameObject.Find("Save_Button").GetComponent<Button>();
        save_buttonn.onClick.AddListener(saveButton);

        jsonn = GameObject.Find("Make_JSON").GetComponent<Button>();
        jsonn.onClick.AddListener(makeJson);

        button_Quitt = GameObject.Find("Button_Quit").GetComponent<Button>();
        button_Quitt.onClick.AddListener(QuitGame);

        menuu = GameObject.Find("Menu").GetComponent<Button>();
        menuu.onClick.AddListener(goToMenu);

        createChar = GameObject.Find("Create Char").GetComponent<Button>();
        Debug.Log(createChar);
        createChar.onClick.AddListener(goToCreateChar);

    }

    public void startScene()
    {
        pName = GameObject.Find("NAME");
        speedW = GameObject.Find("Walking");
        speedR = GameObject.Find("Running");
        speedJ = GameObject.Find("Jumping");

        expP = GameObject.Find("Experience Points");
        hitP = GameObject.Find("Hit Points");
        armorC = GameObject.Find("Armor Class");

        race = GameObject.Find("Races").GetComponent<Dropdown>();
        Class = GameObject.Find("Classes").GetComponent<Dropdown>();
        alignment = GameObject.Find("Alignments").GetComponent<Dropdown>();

        firstRoll = GameObject.Find("1st Roll");
        secondRoll = GameObject.Find("2nd Roll");
        thirdRoll = GameObject.Find("3rd Roll");
        fourthRoll = GameObject.Find("4th Roll");
        fifthRoll = GameObject.Find("5th Roll");

        firstBox = firstRoll.GetComponent<InputField>();
        secondBox = secondRoll.GetComponent<InputField>();
        thirdBox = thirdRoll.GetComponent<InputField>();
        fourthBox = fourthRoll.GetComponent<InputField>();
        fifthBox = fifthRoll.GetComponent<InputField>();

        ability_dropdown = (Dropdown)GameObject.Find("Ability_DICE").GetComponent<Dropdown>();

        Save_B = GameObject.Find("Save_Button");
        save = Save_B.GetComponent<InputField>();

        Player = new Player_State();

        displayStrength = GameObject.Find("Strength");
        displayDexterity = GameObject.Find("Dexterity");
        displayConstitution = GameObject.Find("Constitution");
        displayIntelligence = GameObject.Find("Intelligence");
        displayWisdom = GameObject.Find("Wisdom");
        displayCharisma = GameObject.Find("Charisma");

        disBoxOne = displayStrength.GetComponent<InputField>();

        disBoxTwo = displayDexterity.GetComponent<InputField>();
        disBoxThree = displayConstitution.GetComponent<InputField>();
        disBoxFour = displayIntelligence.GetComponent<InputField>();
        disBoxFive = displayWisdom.GetComponent<InputField>();
        disBoxSix = displayCharisma.GetComponent<InputField>();

        jsonOut = GameObject.Find("JSON output");
        jOutput = jsonOut.GetComponent<InputField>();

        dicee = GameObject.Find("DICE").GetComponent<Button>();
        dicee.onClick.AddListener(Roll_Dice);

        save_buttonn = GameObject.Find("Save_Button").GetComponent<Button>();
        save_buttonn.onClick.AddListener(saveButton);

        jsonn = GameObject.Find("Make_JSON").GetComponent<Button>();
        jsonn.onClick.AddListener(makeJson);

        button_Quitt = GameObject.Find("Button_Quit").GetComponent<Button>();
        button_Quitt.onClick.AddListener(QuitGame);

        menuu = GameObject.Find("Menu").GetComponent<Button>();
        menuu.onClick.AddListener(goToMenu);

        createChar = GameObject.Find("Create Char").GetComponent<Button>();
        Debug.Log(createChar);
        createChar.onClick.AddListener(goToCreateChar);
    }

    public void Roll_Dice()
    {
        roll1 = UnityEngine.Random.Range(1, 7);
        roll2 = UnityEngine.Random.Range(1, 7);
        roll3 = UnityEngine.Random.Range(1, 7);
        roll4 = UnityEngine.Random.Range(1, 7);
        roll5 = UnityEngine.Random.Range(1, 7);

        firstBox.text = roll1.ToString();
        secondBox.text = roll2.ToString();
        thirdBox.text = roll3.ToString();
        fourthBox.text = roll4.ToString();
        fifthBox.text = roll5.ToString();

        int maxOne;
        int maxTwo;
        int maxThree;

        int[] maxRoll = { roll1, roll2, roll3, roll4, roll5 };
        Array.Sort(maxRoll);
        Array.Reverse(maxRoll);

        maxOne = maxRoll[0];
        maxTwo = maxRoll[1];
        maxThree = maxRoll[2];

        max = maxOne + maxTwo + maxThree;
    }

    public void changedName()
    {
        Player.Character_Name = pName.GetComponent<InputField>().text;
    }

    public void storeWalkSpeed()
    {
        Player.Walking_Speed = int.Parse(speedW.GetComponent<InputField>().text);
    }

    public void storeRunSpeed()
    {
        Player.Running_Speed = int.Parse(speedR.GetComponent<InputField>().text);
    }

    public void storeJumpSpeed()
    {
        Player.Jumping_Speed = int.Parse(speedJ.GetComponent<InputField>().text);
    }

    public void storeRace()
    {
        Player.Race = race.options[race.value].text;
    }

    public void storeClass()
    {
        Player.Class = Class.options[Class.value].text;
    }

    public void storeAlignment()
    {
        Player.Alignment = alignment.options[alignment.value].text;
    }

    public void storeExpP()
    {
        Player.Experience_Points = int.Parse(expP.GetComponent<InputField>().text);
    }

    public void storeHitP()
    {
        Player.Hit_Points = int.Parse(hitP.GetComponent<InputField>().text);
    }

    public void storeArmorC()
    {
        Player.Armor_Class = int.Parse(armorC.GetComponent<InputField>().text);
    }

    public void saveButton()
    {
        String abilityName = ability_dropdown.options[ability_dropdown.value].text;

        if(abilityName == "Strength")
        {
            Player.Ability_Strength = max;
            disBoxOne.text = max.ToString();
        }
        if (abilityName == "Dexterity")
        {
            Player.Ability_Dexterity = max;
            disBoxTwo.text = max.ToString();
        }
        if (abilityName == "Constitution")
        {
            Player.Ability_Constitution = max;
            disBoxThree.text = max.ToString();
        }
        if (abilityName == "Intelligence")
        {
            Player.Ability_Intelligence = max;
            disBoxFour.text = max.ToString();
        }
        if (abilityName == "Wisdom")
        {
            Player.Ability_Wisdom = max;
            disBoxFive.text = max.ToString();
        }
        if (abilityName == "Charisma")
        {
            Player.Ability_Charisma = max;
            disBoxSix.text = max.ToString();
        }
    }

    public void makeJson()
    {
        jOutput.text = Player.SaveToString();
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void goToCreateChar()
    {
        SceneManager.LoadScene("Create Your Character");
        //startScene();
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Debug.Log("Quit the game");
    Application.Quit();

#endif
    }
}