using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReceiveVariable : MonoBehaviour
{
 //initialise a string which will be updated every time the sendVariable 
code runs.
 public string increaseScriptTwoNumber;
 void Update()

 {
 //Here the string sent from the sender script is assigned to the 
variable msg.
 //However the information can be accessed directly from 
"increaseScriptTwoNumber".
 string msg = increaseScriptTwoNumber;
 //the information sent from the sender script can be accessed either 
through
 //msg or increaseScriptTwoNumber
 
 //find first comma
 int index1 = msg.IndexOf(',');
 //get rid of writing up to first comma
 string msg1 = msg.Substring(index1 + 1);
 //find distance from comma 1 to comma 2
 int indec2 = msg1.IndexOf(',');
 //Distance from start to second comma
 int index2 = indec2 + index1 + 1;
 //get rid of up to second comma
 string msg2 = msg.Substring(index2 + 1);
 //distance from second to third comma
 int indec3 = msg2.IndexOf(',');
 //Distance from start to third comma
 int index3 = index2 + indec3 + 1;
 //get rid of up to third comma
 string msg3 = msg.Substring(index3 + 1);
 //Delete any information that comes after the number
 string m1 = msg.Substring(0, index1);
 string m2 = msg1.Substring(0, indec2);
 string m3 = msg2.Substring(0, indec3);
 //Convert the string into numbers
 float x = float.Parse(m1);
 float y = float.Parse(m2);
 float z = float.Parse(m3);
 transform.localEulerAngles = new Vector3(x, y, z);
 }
}
