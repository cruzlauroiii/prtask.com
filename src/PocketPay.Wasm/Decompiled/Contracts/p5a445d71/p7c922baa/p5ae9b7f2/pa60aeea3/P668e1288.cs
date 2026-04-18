namespace WillowMaze.Wasm.Decompiled;

public interface P668e1288
{
    pbb861a7f GetCertificateRequest();
    p78a4e424 GetCertificateStatus();
    p64194188 GetCredentials();
    pc9612e59 GetKeyExchange();
    pe94ec29c GetNewSessionTicket();
    int GetSelectedCipherSuite();
    short GetSelectedCompressionMethod();
    Hashtable GetServerExtensions();
    Vector GetServerSupplementalData();
    pb2a46d81 GetServerVersion();
    void Init(p24ae6a1a P0);
    void NotifyClientCertificate(peb0f48a1 P0);
    void NotifyClientVersion(pb2a46d81 P0);
    void NotifyFallback(bool P0);
    void NotifyOfferedCipherSuites(int[] P0);
    void NotifyOfferedCompressionMethods(short[] P0);
    void ProcessClientExtensions(Hashtable P0);
    void ProcessClientSupplementalData(Vector P0);
}
