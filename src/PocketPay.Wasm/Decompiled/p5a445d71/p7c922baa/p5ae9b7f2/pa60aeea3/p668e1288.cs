namespace WillowMaze.Wasm.Decompiled;


public interface p668e1288 : p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p20cbdf86 {
    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pbb861a7f getCertificateRequest() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p78a4e424 getCertificateStatus() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p64194188 getCredentials() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pc9612e59 getKeyExchange() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pe94ec29c getNewSessionTicket() throws java.io.IOException;

    int getSelectedCipherSuite() throws java.io.IOException;

    short getSelectedCompressionMethod() throws java.io.IOException;

    java.util.Hashtable getServerExtensions() throws java.io.IOException;

    java.util.Vector getServerSupplementalData() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb2a46d81 getServerVersion() throws java.io.IOException;

    void init(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p24ae6a1a p24ae6a1aVar);

    void notifyClientCertificate(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var) throws java.io.IOException;

    void notifyClientVersion(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb2a46d81 pb2a46d81Var) throws java.io.IOException;

    void notifyFallback(bool z) throws java.io.IOException;

    void notifyOfferedCipherSuites(int[] iArr) throws java.io.IOException;

    void notifyOfferedCompressionMethods(short[] sArr) throws java.io.IOException;

    void processClientExtensions(java.util.Hashtable hashtable) throws java.io.IOException;

    void processClientSupplementalData(java.util.Vector vector) throws java.io.IOException;
}

