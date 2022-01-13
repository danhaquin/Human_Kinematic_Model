using System.Collections;
using System.Collections.Generic;
using UnityEngine;
54
public class GravityMaker : MonoBehaviour
{
 public GameObject Cube2;
 void OnCollisionEnter(Collision collision)
 {
 Cube2.GetComponent<Rigidbody>().useGravity = true;
 }
 private void Update()
 {
 }
}

//Allows reinstating of gravity on collision preferably with a seperate entity than that which removed gravity
//however, a step counter could allow multiple collisions to togggle gravity on and off.