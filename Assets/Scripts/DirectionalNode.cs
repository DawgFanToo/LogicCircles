﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = left;
        SwitchSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchSprite()
    {
        if(current == "left")
        {
            sr.sprite = left;
        }
        else if(current == "right")
        {
            sr.sprite = right;
        }
        else
        {
            sr.sprite = none;
        }
    }
}
