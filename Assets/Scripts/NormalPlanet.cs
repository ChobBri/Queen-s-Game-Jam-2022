using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPlanet : Planet
{
    Rigidbody2D planetRb;
    protected override void Start()
    {
        planetRb = GetComponent<Rigidbody2D>();   
    }

    public override Vector2 GetPullForce(Rigidbody2D rb)
    {
        const float G = 1;
        Vector2 rawDirection = planetRb.position - rb.position;
        Vector2 normDirection = rawDirection.normalized;
        float lengthSqr = rawDirection.SqrMagnitude();

        return (G * rb.mass * planetRb.mass / lengthSqr) * normDirection;
    }
}