
using UnityEngine;
using UnityEngine.UI;

public class LevelNumber : MonoBehaviour
{
  public Text Text;
  public Game Game;
    public int score;
    [SerializeField] Text scoreText;

    private void Start()
    {
      Text.text = "Level " + (Game.LevelIndex + 1).ToString();
    }
}
