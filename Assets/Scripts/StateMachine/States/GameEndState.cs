﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndState : State
{
    public override void Enter()
    {
        SceneManager.LoadScene("GameOver");
    }
}
