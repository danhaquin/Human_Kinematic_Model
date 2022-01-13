For any Unity code the script name must be the same as the words placed in the public class 
description.
public class Script1 : MonoBehaviour
{
//Unity established as the receiver
 TcpListener listener;
//Initialise variable to be received
 String msg;
 void Start()
 {
//Initiate listening for datagram transmission
 listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1293);
 listener.Start();
 }
 void Update()
 {
//If no transmission has been received then skip to next frame
 if (!listener.Pending())
 { print("hello"); }
//Apply code if a data gram has been received
 else
 {
//Read datagram and send back confirmation of receipt
 TcpClient client = listener.AcceptTcpClient();
 NetworkStream ns = client.GetStream();
 StreamReader reader = new StreamReader(ns);
 msg = reader.ReadToEnd();
 }
 }
}
