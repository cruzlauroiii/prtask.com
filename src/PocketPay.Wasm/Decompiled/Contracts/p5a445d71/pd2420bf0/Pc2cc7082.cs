namespace WillowMaze.Wasm.Decompiled;

public interface Pc2cc7082
{
    pc2cc7082 Cookie(string P0, string P1);
    pc2cc7082 Cookies(Dictionary<string, object> P0);
    pc2cc7082$pe1110b8b Data(string P0);
    pc2cc7082 Data(string P0, string P1);
    pc2cc7082 Data(string P0, string P1, Stream P2);
    pc2cc7082 Data(string P0, string P1, Stream P2, string P3);
    pc2cc7082 Data(ICollection<object> P0);
    pc2cc7082 Data(Dictionary<string, object> P0);
    pc2cc7082 Data(string[] P0);
    pc2cc7082$pd64ed3e9 Execute();
    pc2cc7082 FollowRedirects(bool P0);
    p09453598 Get();
    pc2cc7082 Header(string P0, string P1);
    pc2cc7082 Headers(Dictionary<string, object> P0);
    pc2cc7082 IgnoreContentType(bool P0);
    pc2cc7082 IgnoreHttpErrors(bool P0);
    pc2cc7082 MaxBodySize(int P0);
    pc2cc7082 Method(pc2cc7082$p4c3880bb P0);
    pc2cc7082 Parser(p9a83ab0d P0);
    p09453598 Post();
    pc2cc7082 PostDataCharset(string P0);
    pc2cc7082 Proxy(string P0, int P1);
    pc2cc7082 Proxy(Proxy P0);
    pc2cc7082 Referrer(string P0);
    pc2cc7082$p15c2d85f Request();
    pc2cc7082 Request(pc2cc7082$p15c2d85f P0);
    pc2cc7082 RequestBody(string P0);
    pc2cc7082$pd64ed3e9 Response();
    pc2cc7082 Response(pc2cc7082$pd64ed3e9 P0);
    pc2cc7082 SslSocketFactory(SSLSocketFactory P0);
    pc2cc7082 Timeout(int P0);
    pc2cc7082 Url(string P0);
    pc2cc7082 Url(Uri P0);
    pc2cc7082 UserAgent(string P0);
    pc2cc7082 ValidateTLSCertificates(bool P0);
}
