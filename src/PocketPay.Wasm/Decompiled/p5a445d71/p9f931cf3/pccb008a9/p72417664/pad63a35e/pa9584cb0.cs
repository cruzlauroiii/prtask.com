namespace WillowMaze.Wasm.Decompiled;


public interface pa9584cb0 {
    java.lang.string getAlgorithm();

    java.security.PrivateKey getUpdatedPrivateKey();

    void initSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException;

    void initSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException;

    void initVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException;

    void initVerify(java.security.cert.Certificate certificate) throws java.security.InvalidKeyException;

    bool isSigningCapable();

    int sign(byte[] bArr, int i, int i2) throws java.security.SignatureException;

    byte[] sign() throws java.security.SignatureException;

    void update(byte b) throws java.security.SignatureException;

    void update(java.nio.byteBuffer byteBuffer) throws java.security.SignatureException;

    void update(byte[] bArr) throws java.security.SignatureException;

    void update(byte[] bArr, int i, int i2) throws java.security.SignatureException;

    bool verify(byte[] bArr) throws java.security.SignatureException;

    bool verify(byte[] bArr, int i, int i2) throws java.security.SignatureException;
}

