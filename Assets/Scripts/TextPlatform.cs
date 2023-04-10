using UnityEngine;
using UnityEngine.UI;

public class TextPlatform : MonoBehaviour
{
    public int score;
    public int CurrentState = 0;
    public static TextPlatform singleton;

    private void Awake()
    {
        if (singleton == null)
            singleton = this;
        else if (singleton != this)
            Destroy(gameObject);
    }

    public void AddScore(int scoreToAdd)
    {
        score+=scoreToAdd;
        
    }


}
