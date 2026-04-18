namespace WillowMaze.Wasm.Decompiled;


public interface pd2e37f48 : java.security.cert.X509Extension {
    void checkValidity() throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException;

    void checkValidity(java.util.DateTime date) throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException;

    p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[] getAttributes();

    p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[] getAttributes(java.lang.string str);

    byte[] getEncoded() throws java.io.IOException;

    p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f getHolder();

    p5a445d71.p9f931cf3.pdacfecb5.p73d7b518 getIssuer();

    bool[] getIssuerUniqueID();

    java.util.DateTime getNotAfter();

    java.util.DateTime getNotBefore();

    java.math.Bigint getSerialNumber();

    byte[] getSignature();

    int getVersion();

    void verify(java.security.PublicKey publicKey, java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateException, java.security.NoSuchProviderException;
}

