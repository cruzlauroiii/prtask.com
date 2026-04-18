namespace WillowMaze.Wasm.Decompiled;


public interface pc9612e59 {
    void generateClientKeyExchange(java.io.Stream outputStream) throws java.io.IOException;

    byte[] generatePremasterSecret() throws java.io.IOException;

    byte[] generateServerKeyExchange() throws java.io.IOException;

    void init(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var);

    void processClientCertificate(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var) throws java.io.IOException;

    void processClientCredentials(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p64194188 p64194188Var) throws java.io.IOException;

    void processClientKeyExchange(java.io.Stream inputStream) throws java.io.IOException;

    void processServerCertificate(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var) throws java.io.IOException;

    void processServerCredentials(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p64194188 p64194188Var) throws java.io.IOException;

    void processServerKeyExchange(java.io.Stream inputStream) throws java.io.IOException;

    bool requiresServerKeyExchange();

    void skipClientCredentials() throws java.io.IOException;

    void skipServerCredentials() throws java.io.IOException;

    void skipServerKeyExchange() throws java.io.IOException;

    void validateCertificateRequest(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pbb861a7f pbb861a7fVar) throws java.io.IOException;
}

