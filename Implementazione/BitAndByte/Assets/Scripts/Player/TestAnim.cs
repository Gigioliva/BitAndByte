﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnim : MonoBehaviour {


    private Animator anim;
    private Rigidbody2D rig;
    private int invert;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        anim.SetBool("ParticolState", false);
    }

	void FixedUpdate () {
        invert = rig.gravityScale >= 0 ? 1 : -1;
        anim.SetInteger("Direzione", invert * Sign(rig.velocity.x));
    }

    private int Sign(float vel)
    {
        return vel < 0 ? -1 : (vel > 0 ? 1 : 0);
    }

}
