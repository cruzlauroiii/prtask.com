using System.Net.Sockets;
using System.Net.Security;
using System.Text;
using System.Security.Cryptography;

var Tcp = new TcpClient();
Tcp.Connect("127.0.0.1", 58063);
var Ssl = new SslStream(Tcp.GetStream(), false, (_, _, _, _) => true);
Ssl.AuthenticateAsClient("localhost");

var Key = Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));
var Request = $"GET / HTTP/1.1\r\nHost: localhost:58063\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Key: {Key}\r\nSec-WebSocket-Version: 13\r\n\r\n";

Console.WriteLine($"Sent key: {Key}");
var Expected = Convert.ToBase64String(SHA1.HashData(Encoding.UTF8.GetBytes(Key + "258EAFA5-E914-47DA-95CA-5AB5DC698230")));
Console.WriteLine($"Expected accept: {Expected}");

Ssl.Write(Encoding.UTF8.GetBytes(Request));

var Buffer = new byte[4096];
var Read = Ssl.Read(Buffer, 0, Buffer.Length);
var Response = Encoding.UTF8.GetString(Buffer, 0, Read);
Console.WriteLine($"Response:\n{Response}");

var AcceptLine = Response.Split("\r\n").FirstOrDefault(L => L.StartsWith("Sec-WebSocket-Accept:"));
if (AcceptLine != null)
{
    var Actual = AcceptLine[(AcceptLine.IndexOf(':') + 1)..].Trim();
    Console.WriteLine($"Actual accept: {Actual}");
    Console.WriteLine($"Match: {Actual == Expected}");
}

Tcp.Close();
