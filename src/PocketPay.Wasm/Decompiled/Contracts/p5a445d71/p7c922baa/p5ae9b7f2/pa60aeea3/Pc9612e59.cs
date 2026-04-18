namespace WillowMaze.Wasm.Decompiled;

public interface Pc9612e59
{
    void GenerateClientKeyExchange(Stream P0);
    byte[] GeneratePremasterSecret();
    byte[] GenerateServerKeyExchange();
    void Init(pf1660074 P0);
    void ProcessClientCertificate(peb0f48a1 P0);
    void ProcessClientCredentials(p64194188 P0);
    void ProcessClientKeyExchange(Stream P0);
    void ProcessServerCertificate(peb0f48a1 P0);
    void ProcessServerCredentials(p64194188 P0);
    void ProcessServerKeyExchange(Stream P0);
    bool RequiresServerKeyExchange();
    void SkipClientCredentials();
    void SkipServerCredentials();
    void SkipServerKeyExchange();
    void ValidateCertificateRequest(pbb861a7f P0);
}
