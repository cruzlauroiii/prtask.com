namespace WillowMaze.Wasm.Decompiled;

public interface P02cdb195
{
    p560358a2 GetAuthentication();
    int[] GetCipherSuites();
    Hashtable GetClientExtensions();
    pb2a46d81 GetClientHelloRecordLayerVersion();
    Vector GetClientSupplementalData();
    pb2a46d81 GetClientVersion();
    short[] GetCompressionMethods();
    pc9612e59 GetKeyExchange();
    pfc4c6ea5 GetSessionToResume();
    void Init(p573a79f4 P0);
    bool IsFallback();
    void NotifyNewSessionTicket(pe94ec29c P0);
    void NotifySelectedCipherSuite(int P0);
    void NotifySelectedCompressionMethod(short P0);
    void NotifyServerVersion(pb2a46d81 P0);
    void NotifySessionID(byte[] P0);
    void ProcessServerExtensions(Hashtable P0);
    void ProcessServerSupplementalData(Vector P0);
}
