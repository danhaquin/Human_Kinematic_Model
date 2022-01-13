using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class seperateSphere : MonoBehaviour
{
 public GameObject Sphere;
 float i = 1;
 void OnCollisionEnter(Collision collision)
 {
 Sphere.transform.parent = null;
 
 }
}

//Seperate objects from child parent bond on collision
