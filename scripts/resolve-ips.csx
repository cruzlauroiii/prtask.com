var HexIps = new[] { "76B97B03", "0A0F4403", "6D12AC12", "5F76FDAC", "64AAE940", "3215AC12" };

foreach (var Hex in HexIps)
{
    var Bytes = Convert.FromHexString(Hex);
    Array.Reverse(Bytes);
    var Ip = new System.Net.IPAddress(Bytes);
    var Host = "(no reverse DNS)";
    try { Host = System.Net.Dns.GetHostEntry(Ip).HostName; } catch { }
    Console.WriteLine($"{Hex} -> {Ip} -> {Host}");
}
