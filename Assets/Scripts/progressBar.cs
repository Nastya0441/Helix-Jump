using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progressBar : MonoBehaviour
{
   public Player Player;
    public Transform FinishPlatform;
    public Slider Slider;

    private float _startY;
    private float _minReachedY;

    private void Start()
    {
        _startY = Player.transform.position.y;
    }
    private void Update()
    {
        _minReachedY = Mathf.Min(_minReachedY,Player.transform.position.y);
        float currentY = Player.transform.position.y;
        float finishY=FinishPlatform.position.y;
        float t = Mathf.InverseLerp(_startY,finishY,_minReachedY);
        Slider.value = t;
        
    }
}
