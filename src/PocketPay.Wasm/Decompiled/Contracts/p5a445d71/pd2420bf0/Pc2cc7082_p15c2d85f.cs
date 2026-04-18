namespace WillowMaze.Wasm.Decompiled;

public interface Pc2cc7082_p15c2d85f
{
    ICollection<object> Data();
    pc2cc7082$p15c2d85f Data(pc2cc7082$pe1110b8b P0);
    pc2cc7082$p15c2d85f FollowRedirects(bool P0);
    bool FollowRedirects();
    pc2cc7082$p15c2d85f IgnoreContentType(bool P0);
    bool IgnoreContentType();
    pc2cc7082$p15c2d85f IgnoreHttpErrors(bool P0);
    bool IgnoreHttpErrors();
    int MaxBodySize();
    pc2cc7082$p15c2d85f MaxBodySize(int P0);
    p9a83ab0d Parser();
    pc2cc7082$p15c2d85f Parser(p9a83ab0d P0);
    string PostDataCharset();
    pc2cc7082$p15c2d85f PostDataCharset(string P0);
    Proxy Proxy();
    pc2cc7082$p15c2d85f Proxy(string P0, int P1);
    pc2cc7082$p15c2d85f Proxy(Proxy P0);
    string RequestBody();
    pc2cc7082$p15c2d85f RequestBody(string P0);
    SSLSocketFactory SslSocketFactory();
    void SslSocketFactory(SSLSocketFactory P0);
    int Timeout();
    pc2cc7082$p15c2d85f Timeout(int P0);
    void ValidateTLSCertificates(bool P0);
    bool ValidateTLSCertificates();
}
