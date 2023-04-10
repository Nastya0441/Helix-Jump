using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [SerializeField] private Text textScore;

    private void Update()
    {
        textScore.text = " " + TextPlatform.singleton.score;
        
    }

}

