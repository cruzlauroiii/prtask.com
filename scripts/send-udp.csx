using System.Net;
using System.Net.Sockets;
using System.Text;

var Message = Encoding.UTF8.GetBytes("{\"Service\":\"TranspilerBackoffice\",\"WssPort\":49897}");

var Client = new UdpClient();
Client.EnableBroadcast = true;

Client.Send(Message, Message.Length, new IPEndPoint(IPAddress.Parse("192.168.100.103"), 8770));
Console.WriteLine("Sent direct to 192.168.100.103:8770");

Client.Send(Message, Message.Length, new IPEndPoint(IPAddress.Parse("192.168.100.255"), 8770));
Console.WriteLine("Sent to 192.168.100.255:8770");

Client.Send(Message, Message.Length, new IPEndPoint(IPAddress.Broadcast, 8770));
Console.WriteLine("Sent to 255.255.255.255:8770");
