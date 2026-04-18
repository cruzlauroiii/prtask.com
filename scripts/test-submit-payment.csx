using System.Net.Sockets;
using System.Net.Security;
using System.Text;
using System.Security.Cryptography;

var Tcp = new TcpClient();
Tcp.Connect("127.0.0.1", 8769);
var Ssl = new SslStream(Tcp.GetStream(), false, (_, _, _, _) => true);
Ssl.AuthenticateAsClient("localhost");

var Key = Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));
var Handshake = $"GET / HTTP/1.1\r\nHost: localhost:8769\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Key: {Key}\r\nSec-WebSocket-Version: 13\r\n\r\n";
Ssl.Write(Encoding.UTF8.GetBytes(Handshake));
var RespBuf = new byte[1024];
var RespLen = Ssl.Read(RespBuf, 0, RespBuf.Length);
if (!Encoding.UTF8.GetString(RespBuf, 0, RespLen).Contains("101")) { Console.WriteLine("Handshake failed"); return; }
Console.WriteLine("WSS connected");

void WsSend(string Text)
{
    var Payload = Encoding.UTF8.GetBytes(Text);
    var Mask = RandomNumberGenerator.GetBytes(4);
    var Ms = new System.IO.MemoryStream();
    Ms.WriteByte(0x81);
    if (Payload.Length < 126) Ms.WriteByte((byte)(0x80 | Payload.Length));
    else { Ms.WriteByte(0xFE); Ms.WriteByte((byte)(Payload.Length >> 8)); Ms.WriteByte((byte)(Payload.Length & 0xFF)); }
    Ms.Write(Mask, 0, 4);
    for (var I = 0; I < Payload.Length; I++) Ms.WriteByte((byte)(Payload[I] ^ Mask[I % 4]));
    var Frame = Ms.ToArray();
    Ssl.Write(Frame, 0, Frame.Length);
    Ssl.Flush();
}

string WsReceive()
{
    var H = new byte[2];
    Ssl.Read(H, 0, 2);
    var Len = (int)(H[1] & 0x7F);
    if (Len == 126) { var E = new byte[2]; Ssl.Read(E, 0, 2); Len = (E[0] << 8) | E[1]; }
    var Data = new byte[Len];
    var Read = 0;
    while (Read < Len) { var N = Ssl.Read(Data, Read, Len - Read); if (N <= 0) break; Read += N; }
    return Encoding.UTF8.GetString(Data);
}

WsSend("{\"ClientType\":\"Browser\"}");
Console.WriteLine("Registered: " + WsReceive());

WsSend("{\"Method\":\"SubmitPayment\",\"Amount\":100}");
Console.WriteLine("Sent SubmitPayment (1 PHP)");

Tcp.ReceiveTimeout = 60000;
for (var I = 0; I < 3; I++)
{
    try
    {
        var Msg = WsReceive();
        Console.WriteLine("Received: " + (Msg.Length > 300 ? Msg[..300] + "..." : Msg));
        if (Msg.Contains("PaymentResult")) break;
    }
    catch (Exception Ex) { Console.WriteLine("Timeout: " + Ex.Message); break; }
}
Tcp.Close();
