using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSoundClick : MonoBehaviour, IPointerEnterHandler
{
    private PlaySound playSound;
    public string buttonClick;
    public CanvasGroup panelButton;

    private void Start()
    {
        playSound = GetComponentInChildren<PlaySound>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(playSound) playSound.Play(buttonClick);
    }
    
}
