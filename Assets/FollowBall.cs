using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] float speed = 1;

    public bool IsMoving => this.transform.position == ball.Position;
    void Update()
    {
        if (this.transform.position == ball.Position)
        {
            return;
        }

        this.transform.position = Vector3.Lerp(
            this.transform.position,
            ball.Position,
            Time.deltaTime * speed
        );

        if (ball.IsMoving)
        {
           return; 
        }

        //kalai udah deket banget langsung teleport aja
        if(Vector3.Distance(transform.position, ball.Position) < 0.3)
        {
            transform.position = ball.Position;
        }

    }
}
