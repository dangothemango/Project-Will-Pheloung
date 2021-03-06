﻿using UnityEngine;
using System.Collections;
using System;

public class PhasePlatform : BeatObject {

    public bool solid;
    MeshRenderer render;
    Collider collide;

    protected override void beat1()
    {
        solid = !solid;
        render.enabled = collide.enabled = solid;
    }

    // Use this for initialization
    new void Start () {
        base.Start();

        render = gameObject.GetComponent<MeshRenderer>();
        collide = gameObject.GetComponent<Collider>();
        render.enabled = collide.enabled = solid;
    }
	
	// Update is called once per frame
	new void Update () {
        base.Update();  // It's here just in case anything is added to its base class's Update()
	}
}
