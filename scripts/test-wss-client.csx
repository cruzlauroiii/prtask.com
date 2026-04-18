using System.Net.WebSockets;
using System.Text;
using System.Threading;

var Ws = new ClientWebSocket();
Ws.Options.RemoteCertificateValidationCallback = (_, _, _, _) => true;

Console.WriteLine("Connecting to wss://localhost:58063...");
await Ws.ConnectAsync(new Uri("wss://localhost:58063"), CancellationToken.None);
Console.WriteLine("Connected!");

var Register = Encoding.UTF8.GetBytes("{\"ClientType\":\"Browser\"}");
await Ws.SendAsync(Register, WebSocketMessageType.Text, true, CancellationToken.None);
Console.WriteLine("Sent registration");

var Buffer = new byte[4096];
var Result = await Ws.ReceiveAsync(Buffer, CancellationToken.None);
var Response = Encoding.UTF8.GetString(Buffer, 0, Result.Count);
Console.WriteLine("Response: " + Response);

var LoginMsg = Encoding.UTF8.GetBytes("{\"Method\":\"Login\",\"Id\":\"1\",\"Payload\":{\"Phone\":\"639568564236\",\"Password\":\"test123\"}}");
await Ws.SendAsync(LoginMsg, WebSocketMessageType.Text, true, CancellationToken.None);
Console.WriteLine("Sent login");

Result = await Ws.ReceiveAsync(Buffer, CancellationToken.None);
Response = Encoding.UTF8.GetString(Buffer, 0, Result.Count);
Console.WriteLine("Login response: " + Response[..Math.Min(200, Response.Length)]);

await Ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
Console.WriteLine("Done");
