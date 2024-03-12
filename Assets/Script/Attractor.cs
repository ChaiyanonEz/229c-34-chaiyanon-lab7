using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private float G = 6.674f; //F = G(m1*m2)/r^2

    void Attract(Attractor other)
    {
        Rigidbody rb2 = other.rb;
        
        //F = G(m1*m2)/r^2
        Vector3 direction = rb.position - rb2.position;
        
        //Find Distance beteen 2 objects from Vector3
        float distance = direction.magnitude;

        float forceMagnitude = G*(rb.mass * rb2.mass)/Mathf.Pow(distance,2);

        Vector3 finalForce = forceMagnitude * direction.normalized;
        
        rb.AddForce(finalForce);

    }


}//end
