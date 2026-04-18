var Domains = new[] {
    "wc.psr.it.com", "api.psr.it.com", "app.psr.it.com",
    "pocketpay.psr.it.com", "gcash.psr.it.com",
    "wc.psr.ua", "api.psr.ua", "psr.it.com", "psr.ua",
    "wc-gcash.psr.it.com", "gcash-api.psr.it.com",
    "wc.gcash.psr.it.com", "pocketpay-api.psr.it.com"
};

foreach (var D in Domains)
{
    try
    {
        var Addrs = System.Net.Dns.GetHostAddresses(D);
        Console.WriteLine($"{D} -> {string.Join(", ", Addrs.Select(A => A.ToString()))}");
    }
    catch
    {
        Console.WriteLine($"{D} -> NXDOMAIN");
    }
}
