using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityNullifier : MonoBehaviour
{
 public GameObject Cube2;
 void OnCollisionEnter(Collision collision)
 {
Cube2.GetComponent<Rigidbody>().useGravity = false;
 }
 private void Update()
 {
 
 }
}
