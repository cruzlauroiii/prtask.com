namespace WillowMaze.Wasm.Decompiled;


public interface pb3b7fb02 {
    java.security.AlgorithmParameterGenerator createAlgorithmParameterGenerator(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.AlgorithmParameters createAlgorithmParameters(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.cert.CertPathBuilder createCertPathBuilder(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.cert.CertPathValidator createCertPathValidator(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.cert.CertStore createCertStore(java.lang.string str, java.security.cert.CertStoreParameters certStoreParameters) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException, java.security.InvalidAlgorithmParameterException;

    java.security.cert.CertificateFactory createCertificateFactory(java.lang.string str) throws java.security.cert.CertificateException, java.security.NoSuchProviderException;

    javax.crypto.Cipher createCipher(java.lang.string str) throws javax.crypto.NoSuchPaddingException, java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.MessageDigest createDigest(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    javax.crypto.ExemptionMechanism createExemptionMechanism(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    javax.crypto.KeyAgreement createKeyAgreement(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.KeyFactory createKeyFactory(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    javax.crypto.KeyGenerator createKeyGenerator(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.KeyValueTupleGenerator createKeyValueTupleGenerator(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.KeyStore createKeyStore(java.lang.string str) throws java.security.KeyStoreException, java.security.NoSuchProviderException;

    javax.crypto.Mac createMac(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.MessageDigest createMessageDigest(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    javax.crypto.SecretKeyFactory createSecretKeyFactory(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.SecureRandom createSecureRandom(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;

    java.security.Signature createSignature(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException;
}

