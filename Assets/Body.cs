// using System.Collections;
// using System.Collections.Generic;

using System;
using UnityEngine;

public class Body : MonoBehaviour
{
    private float _positionPhase = 0.0f;
    private float _positionAmplitude = 0.02f;
    private float _positionDPhase = 0.1f;
    private float _rotationAmplitude = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new(-0.03f, 0.75f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3((float) (this._positionAmplitude * Math.Cos(this._positionPhase)),0.0f);
        transform.Rotate(0.0f, 0.0f, (float) (this._rotationAmplitude * Math.Cos(this._positionPhase)));
        this._positionPhase += this._positionDPhase;
    }
}
