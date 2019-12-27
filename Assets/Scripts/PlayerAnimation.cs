﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void SetSpeed(int speed)
    {
        anim.SetInteger("Speed", speed);
    }
}
