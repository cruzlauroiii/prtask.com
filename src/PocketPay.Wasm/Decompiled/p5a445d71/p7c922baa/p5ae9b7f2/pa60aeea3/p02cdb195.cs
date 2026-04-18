namespace WillowMaze.Wasm.Decompiled;


public interface p02cdb195 : p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p20cbdf86 {
    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p560358a2 getAuthentication() throws java.io.IOException;

    int[] getCipherSuites();

    java.util.Hashtable getClientExtensions() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb2a46d81 getClientHelloRecordLayerVersion();

    java.util.Vector getClientSupplementalData() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb2a46d81 getClientVersion();

    short[] getCompressionMethods();

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pc9612e59 getKeyExchange() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfc4c6ea5 getSessionToResume();

    void init(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p573a79f4 p573a79f4Var);

    bool isFallback();

    void notifyNewSessionTicket(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pe94ec29c pe94ec29cVar) throws java.io.IOException;

    void notifySelectedCipherSuite(int i);

    void notifySelectedCompressionMethod(short s);

    void notifyServerVersion(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb2a46d81 pb2a46d81Var) throws java.io.IOException;

    void notifySessionID(byte[] bArr);

    void processServerExtensions(java.util.Hashtable hashtable) throws java.io.IOException;

    void processServerSupplementalData(java.util.Vector vector) throws java.io.IOException;
}

