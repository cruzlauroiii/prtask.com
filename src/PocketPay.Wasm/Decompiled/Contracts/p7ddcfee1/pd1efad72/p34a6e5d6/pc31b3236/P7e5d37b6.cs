namespace WillowMaze.Wasm.Decompiled;

public interface P7e5d37b6
{
    void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2);
    string GetSelectedProtocol(SSLSocket P0);
    bool IsSupported();
    bool MatchesSocket(SSLSocket P0);
    bool MatchesSocketFactory(SSLSocketFactory P0);
    X509TrustManager TrustManager(SSLSocketFactory P0);
}
