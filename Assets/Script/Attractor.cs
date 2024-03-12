using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    void Attract(Attractor other)
    {
        Rigidbody rb2 = other.rb;
    }


}
