using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRigidBody;
    public InGameTimer InGameTimer;
    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = this.GetComponent<Rigidbody>();

        var ballData = new BallData(5);
        Debug.Log(ballData.GetHitPoint);//5
    }

    public void BallMove(Vector3 direction)
    {
        ballRigidBody.AddForce(direction);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Cube")
        {
            Debug.Log("Damage");
        }
    }

    private void Update()
    {
        if(InGameTimer.GetTimerTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
