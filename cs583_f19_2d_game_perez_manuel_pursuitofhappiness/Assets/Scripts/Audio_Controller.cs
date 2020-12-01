using UnityEngine;

public class Audio_Controller : MonoBehaviour
{
    protected static Audio_Controller instance;

    public static Audio_Controller Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }


}
