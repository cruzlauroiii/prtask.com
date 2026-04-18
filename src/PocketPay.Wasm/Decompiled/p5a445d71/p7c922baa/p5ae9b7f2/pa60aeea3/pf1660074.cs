namespace WillowMaze.Wasm.Decompiled;


public interface pf1660074 {
    byte[] exportKeyingMaterial(java.lang.string str, byte[] bArr, int i);

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb2a46d81 getClientVersion();

    p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd getNonceRandomGenerator();

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfc4c6ea5 getResumableSession();

    java.security.SecureRandom getSecureRandom();

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p937e6f23 getSecurityParameters();

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pb2a46d81 getServerVersion();

    java.lang.object getUserobject();

    bool isServer();

    void setUserobject(java.lang.object obj);
}

