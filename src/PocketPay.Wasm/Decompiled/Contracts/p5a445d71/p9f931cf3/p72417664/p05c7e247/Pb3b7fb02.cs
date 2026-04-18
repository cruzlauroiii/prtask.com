namespace WillowMaze.Wasm.Decompiled;

public interface Pb3b7fb02
{
    AlgorithmParameterGenerator CreateAlgorithmParameterGenerator(string P0);
    AlgorithmParameters CreateAlgorithmParameters(string P0);
    CertPathBuilder CreateCertPathBuilder(string P0);
    CertPathValidator CreateCertPathValidator(string P0);
    CertStore CreateCertStore(string P0, CertStoreParameters P1);
    CertificateFactory CreateCertificateFactory(string P0);
    System.Security.Cryptography.Aes CreateCipher(string P0);
    System.Security.Cryptography.HashAlgorithm CreateDigest(string P0);
    ExemptionMechanism CreateExemptionMechanism(string P0);
    KeyAgreement CreateKeyAgreement(string P0);
    KeyFactory CreateKeyFactory(string P0);
    KeyGenerator CreateKeyGenerator(string P0);
    KeyPairGenerator CreateKeyPairGenerator(string P0);
    System.Security.Cryptography.X509Certificates.X509Store CreateKeyStore(string P0);
    System.Security.Cryptography.HMAC CreateMac(string P0);
    System.Security.Cryptography.HashAlgorithm CreateMessageDigest(string P0);
    SecretKeyFactory CreateSecretKeyFactory(string P0);
    System.Security.Cryptography.RandomNumberGenerator CreateSecureRandom(string P0);
    Signature CreateSignature(string P0);
}
