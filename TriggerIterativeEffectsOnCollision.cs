using System.Collections;
using UnityEngine;
public class colour_change : MonoBehaviour
{
 bool blue;
 bool green;
 bool red;
 bool yellow;
 int counter;
 void Start()
 {
 blue = true;
 }
 void Update()
 {
 if (blue == true)
 gameObject.GetComponent<Renderer>().material.color = Color.blue;
 if (green == true)
 gameObject.GetComponent<Renderer>().material.color = Color.green;
 if (yellow == true)
 gameObject.GetComponent<Renderer>().material.color = Color.yellow;
 if (red == true)
 gameObject.GetComponent<Renderer>().material.color = Color.red;
 }
 void OnCollisionEnter()
 {
 if (counter == 0)
 {
 blue = false;
 green = true;
 counter = 1;
 }
 else if (counter == 1)
 {
 green = false;
 yellow = true;
 counter = 2;
 }
 else if (counter == 2)
 {
 yellow = false;
 red = true;
 counter = 2;
 }
 else if (counter == 3)
 {
 red = false;
 blue = true;
 counter = 2;
 }
 }
}

// Can also be used to trigger texture audio and animations 