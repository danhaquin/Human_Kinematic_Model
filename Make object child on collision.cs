using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JoinSphere : MonoBehaviour
{
 public GameObject Sphere;
 float i = 1;
 void OnCollisionEnter(Collision collision)
 {
 
 Sphere.transform.parent = GameObject.Find("Body1:1").transform;
 }
}

//when this code is combined witht he no gravity code the result is that bon collision both objects stick together.