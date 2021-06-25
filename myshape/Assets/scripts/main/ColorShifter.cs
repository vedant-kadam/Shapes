﻿
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorShifter : MonoBehaviour
{
    public Color endColor;
    public float colorUpdateRate;
    public Color[] colors;
   
    private Image image;

    private void Start()
    {

        image = GetComponent<Image>();

    }

    private void Update()
    {
        image.color = Color.Lerp(image.color, endColor, Time.deltaTime );
        if(endColor == image.color)
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        endColor = Random.ColorHSV(0.8f,1,0.8f,1f,0.8f,1f,0.8f,1);// colors[Random.Range(0, colors.Length)];
        yield return new WaitForSeconds(colorUpdateRate);
        
    }

   








}
