public class sendVariable : MonoBehaviour
{
 //Create reference to the game object you are sending data to
 GameObject obj;
 // create a string to hold information
 string msg0;
 
 void Awake()
 {
 //specify what object information is being sent to in this case the 
object has 
 //the label "receiver" applied.
 obj = GameObject.FindGameObjectWithTag("reciever");
 }
 // Update is called once per frame
 void Update()
 {
 if (Time.time < 4)
 {
 msg0 = "1,13,1414,";
 //send information contained in the string msg0
 obj.GetComponent<ReceiveVariable>().increaseScriptTwoNumber = msg0;
 }
 else
 {
 msg0 = "chicken";
 //send information contained in the string msg0
 obj.GetComponent<ReceiveVariable>().increaseScriptTwoNumber = msg0;
 }
 }
}