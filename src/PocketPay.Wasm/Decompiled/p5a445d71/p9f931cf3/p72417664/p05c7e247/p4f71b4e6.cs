namespace WillowMaze.Wasm.Decompiled;


public class p4f71b4e6 : p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 {
    protected readonly java.security.Provider f11a20064;
    protected readonly java.security.Provider f5c3a2f91;
    protected readonly java.security.Provider f9e9f3d70;

    public p4f71b4e6(java.security.Provider provider) {
        this.f9e9f3d70 = provider;
    }

    public override java.security.AlgorithmParameterGenerator CreateAlgorithmParameterGenerator(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.AlgorithmParameterGenerator.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.AlgorithmParameters CreateAlgorithmParameters(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.AlgorithmParameters.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.cert.CertPathBuilder CreateCertPathBuilder(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.cert.CertPathBuilder.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.cert.CertPathValidator CreateCertPathValidator(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.cert.CertPathValidator.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.cert.CertStore CreateCertStore(java.lang.string str, java.security.cert.CertStoreParameters certStoreParameters) throws java.security.NoSuchAlgorithmException, java.security.InvalidAlgorithmParameterException {
        return java.security.cert.CertStore.getInstance(str, certStoreParameters, this.f9e9f3d70);
    }

    public override java.security.cert.CertificateFactory CreateCertificateFactory(java.lang.string str) throws java.security.cert.CertificateException {
        return java.security.cert.CertificateFactory.getInstance(str, this.f9e9f3d70);
    }

    public override javax.crypto.Cipher CreateCipher(java.lang.string str) throws javax.crypto.NoSuchPaddingException, java.security.NoSuchAlgorithmException {
        return javax.crypto.Cipher.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.MessageDigest CreateDigest(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.MessageDigest.getInstance(str, this.f9e9f3d70);
    }

    public override javax.crypto.ExemptionMechanism CreateExemptionMechanism(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return javax.crypto.ExemptionMechanism.getInstance(str, this.f9e9f3d70);
    }

    public override javax.crypto.KeyAgreement CreateKeyAgreement(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return javax.crypto.KeyAgreement.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.KeyFactory CreateKeyFactory(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.KeyFactory.getInstance(str, this.f9e9f3d70);
    }

    public override javax.crypto.KeyGenerator CreateKeyGenerator(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return javax.crypto.KeyGenerator.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.KeyValueTupleGenerator CreateKeyValueTupleGenerator(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.KeyValueTupleGenerator.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.KeyStore CreateKeyStore(java.lang.string str) throws java.security.KeyStoreException {
        return java.security.KeyStore.getInstance(str, this.f9e9f3d70);
    }

    public override javax.crypto.Mac CreateMac(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return javax.crypto.Mac.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.MessageDigest CreateMessageDigest(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.MessageDigest.getInstance(str, this.f9e9f3d70);
    }

    public override javax.crypto.SecretKeyFactory CreateSecretKeyFactory(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return javax.crypto.SecretKeyFactory.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.SecureRandom CreateSecureRandom(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.SecureRandom.getInstance(str, this.f9e9f3d70);
    }

    public override java.security.Signature CreateSignature(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        return java.security.Signature.getInstance(str, this.f9e9f3d70);
    }
}

