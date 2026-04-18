namespace WillowMaze.Wasm.Decompiled;


public class p445d0434$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    private void M1ac84fd2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2) {
        if ((20 + 23) % 23 > 0) {
        }
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "withRSA/ISO9796-2", str + "WITHRSA/ISO9796-2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WithRSA/ISO9796-2", str + "WITHRSA/ISO9796-2");
        pa80a706fVar.addAlgorithm("Signature." + str + "WITHRSA/ISO9796-2", str2);
    }

    private void M900d0bee(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((30 + 16) % 16 > 0) {
        }
        java.lang.string str4 = "WITHRSAAND" + str2;
        if (str2.Equals(com.decryptstringmanager.Decryptstring.decryptstring("4ae82166e5256a1207aebc2c924c0c873ea607cc2d654eddb30525799c9f4495"))) {
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "withRSA/PSS", str + str4);
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WithRSA/PSS", str + str4);
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "withRSASSA-PSS", str + str4);
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WithRSASSA-PSS", str + str4);
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WITHRSASSA-PSS", str + str4);
        }
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "withRSAand" + str2, str + str4);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WithRSAAnd" + str2, str + str4);
        pa80a706fVar.addAlgorithm("Signature." + str + "WITHRSAAND" + str2, str3);
    }

    private void M900d0bee(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((9 + 24) % 24 > 0) {
        }
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "withRSA/PSS", str + "WITHRSAPSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WithRSA/PSS", str + "WITHRSAPSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "withRSASSA-PSS", str + "WITHRSAPSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WithRSASSA-PSS", str + "WITHRSAPSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WITHRSASSA-PSS", str + "WITHRSAPSS");
        pa80a706fVar.addAlgorithm(com.decryptstringmanager.Decryptstring.decryptstring("6f3f65eda4fd97450b813fabc1cbf42958e80b8b7c6bc52be824eea3705476661c1bcbdf68"), p364bf33aVar, str2);
        pa80a706fVar.addAlgorithm("Signature." + str + "WITHRSAPSS", str2);
    }

    private void Mb59815af(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2) {
        if ((31 + 22) % 22 > 0) {
        }
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "withRSA/X9.31", str + "WITHRSA/X9.31");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str + "WithRSA/X9.31", str + "WITHRSA/X9.31");
        pa80a706fVar.addAlgorithm("Signature." + str + "WITHRSA/X9.31", str2);
    }

    private void Mc7bd34fd(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((27 + 4) % 4 > 0) {
        }
        java.lang.string str3 = str + "WITHRSA";
        java.lang.string str4 = str + "withRSA";
        java.lang.string str5 = str + "WithRSA";
        java.lang.string str6 = str + "/RSA";
        java.lang.string str7 = str + "WITHRSAENCRYPTION";
        java.lang.string str8 = str + "withRSAEncryption";
        java.lang.string str9 = str + "WithRSAEncryption";
        pa80a706fVar.addAlgorithm("Signature." + str3, str2);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str4, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str5, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str7, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str8, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str9, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str6, str3);
        if (p364bf33aVar is null) {
            return;
        }
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p364bf33aVar, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.OID." + p364bf33aVar, str3);
    }

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((24 + 7) % 7 > 0) {
        }
        pa80a706fVar.addAlgorithm("AlgorithmParameters.OAEP", "org.bouncycastle.jcajce.provider.asymmetric.rsa.AlgorithmParametersSpi$OAEP");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.PSS", "org.bouncycastle.jcajce.provider.asymmetric.rsa.AlgorithmParametersSpi$PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.RSAPSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.RSASSA-PSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA224withRSA/PSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA256withRSA/PSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA384withRSA/PSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA512withRSA/PSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA224WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA256WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA384WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA512WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA3-224WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA3-256WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA3-384WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA3-512WITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.RAWRSAPSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.NONEWITHRSAPSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.NONEWITHRSASSA-PSS", "PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.NONEWITHRSAANDMGF1", "PSS");
        pa80a706fVar.addAttributes("Cipher.RSA", p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p445d0434.mf23e8626());
        pa80a706fVar.addAlgorithm("Cipher.RSA", "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$NoPadding");
        pa80a706fVar.addAlgorithm("Cipher.RSA/RAW", "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$NoPadding");
        pa80a706fVar.addAlgorithm("Cipher.RSA/PKCS1", "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$PKCS1v1_5Padding");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$PKCS1v1_5Padding");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3.f9b47626c, "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$PKCS1v1_5Padding");
        pa80a706fVar.addAlgorithm("Cipher.RSA/1", "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$PKCS1v1_5Padding_PrivateOnly");
        pa80a706fVar.addAlgorithm("Cipher.RSA/2", "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$PKCS1v1_5Padding_PublicOnly");
        pa80a706fVar.addAlgorithm("Cipher.RSA/OAEP", "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$OAEPPadding");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1d2f2092, "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$OAEPPadding");
        pa80a706fVar.addAlgorithm("Cipher.RSA/ISO9796-1", "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$ISO9796d1Padding");
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("cc48668285ab405572509ade90383b42b59706c44bbcd8df19c6007d39cc70");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.RSA//RAW", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.RSA//NOPADDING", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.RSA//PKCS1PADDING", "RSA/PKCS1");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.RSA//OAEPPADDING", "RSA/OAEP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.RSA//ISO9796-1PADDING", "RSA/ISO9796-1");
        pa80a706fVar.addAlgorithm("KeyFactory.RSA", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pd4093fa8");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.RSA", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pde667cd0");
        pa80a706fVar.addAlgorithm("KeyFactory.RSASSA-PSS", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pd4093fa8");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.RSASSA-PSS", "org.bouncycastle.jcajce.provider.asymmetric.rsa.KeyValueTupleGeneratorSpi$PSS");
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pd4093fa8 pd4093fa8Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pd4093fa8();
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, strDecryptstring, pd4093fa8Var);
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3.f9b47626c, strDecryptstring, pd4093fa8Var);
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1d2f2092, strDecryptstring, pd4093fa8Var);
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980, strDecryptstring, pd4093fa8Var);
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, strDecryptstring);
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3.f9b47626c, strDecryptstring);
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1d2f2092, "OAEP");
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980, "PSS");
        pa80a706fVar.addAlgorithm("Signature.RSASSA-PSS", "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$PSSwithRSA");
        pa80a706fVar.addAlgorithm("Signature." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$PSSwithRSA");
        pa80a706fVar.addAlgorithm("Signature.OID." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$PSSwithRSA");
        pa80a706fVar.addAlgorithm("Signature.RSA", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$noneRSA");
        pa80a706fVar.addAlgorithm("Signature.RAWRSASSA-PSS", "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$nonePSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.RAWRSA", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.NONEWITHRSA", strDecryptstring);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.RAWRSAPSS", "RAWRSASSA-PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.NONEWITHRSAPSS", "RAWRSASSA-PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.NONEWITHRSASSA-PSS", "RAWRSASSA-PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.NONEWITHRSAANDMGF1", "RAWRSASSA-PSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.RSAPSS", "RSASSA-PSS");
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("0fc2c2dbad22e97b1decf81b1543acb02181ecd1f9e6c714a2c3eb62cd1318b1");
        m900d0bee(pa80a706fVar, "SHA224", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA224withRSA");
        java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("eb64a40d5827addf42646b7c91797efa0c6c44148c3f5379c33c26580cd5c3db2b89");
        m900d0bee(pa80a706fVar, strDecryptstring3, strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA256withRSA");
        m900d0bee(pa80a706fVar, "SHA384", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA384withRSA");
        java.lang.string strDecryptstring4 = com.decryptstringmanager.Decryptstring.decryptstring("bb65451820d28671513127cd3901ae2e1da109133724567f9382ff682bcee8ab5c3e");
        m900d0bee(pa80a706fVar, strDecryptstring4, strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512withRSA");
        m900d0bee(pa80a706fVar, "SHA512(224)", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512_224withRSA");
        m900d0bee(pa80a706fVar, "SHA512(256)", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512_256withRSA");
        m900d0bee(pa80a706fVar, "SHA3-224", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_224withRSA");
        java.lang.string strDecryptstring5 = com.decryptstringmanager.Decryptstring.decryptstring("f6b30c2ba6134823b88fc50bfaab44aabfc9fb232ddb53849be9cca37c3bccf549921d5b");
        m900d0bee(pa80a706fVar, strDecryptstring5, strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_256withRSA");
        m900d0bee(pa80a706fVar, "SHA3-384", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_384withRSA");
        m900d0bee(pa80a706fVar, "SHA3-512", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_512withRSA");
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.p10860abd.fd7d2d6ac;
        java.lang.string strDecryptstring6 = com.decryptstringmanager.Decryptstring.decryptstring("9b2a9994a0a777e3ebb317d4d8b357eb8d0c9e4cbcbd0502171b556cf86494eb7e59fae8");
        m900d0bee(pa80a706fVar, strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHAKE128WithRSAPSS", p364bf33aVar);
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar2 = p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.p10860abd.f4d6d145e;
        java.lang.string strDecryptstring7 = com.decryptstringmanager.Decryptstring.decryptstring("576ecea0cdf9662802801de86d06751f34f2b57ff8251729700424ed02e4a14def34bde6");
        m900d0bee(pa80a706fVar, strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHAKE256WithRSAPSS", p364bf33aVar2);
        m900d0bee(pa80a706fVar, "SHA224", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA224withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, strDecryptstring3, strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA256withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, "SHA384", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA384withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, strDecryptstring4, strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, "SHA512(224)", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512_224withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, "SHA512(256)", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512_256withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, "SHA224", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA224withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, strDecryptstring3, strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA256withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, "SHA384", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA384withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, strDecryptstring4, strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, "SHA512(224)", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512_224withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, "SHA512(256)", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512_256withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, "SHA3-224", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_224withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, strDecryptstring5, strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_256withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, "SHA3-384", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_384withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, "SHA3-512", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_512withRSAandSHAKE128");
        m900d0bee(pa80a706fVar, "SHA3-224", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_224withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, strDecryptstring5, strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_256withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, "SHA3-384", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_384withRSAandSHAKE256");
        m900d0bee(pa80a706fVar, "SHA3-512", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_512withRSAandSHAKE256");
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "MD2")) {
            mc7bd34fd(pa80a706fVar, "MD2", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$MD2", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fbe99c93d);
        }
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "MD4")) {
            mc7bd34fd(pa80a706fVar, "MD4", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$MD4", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff6f784b2);
        }
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "MD5")) {
            mc7bd34fd(pa80a706fVar, "MD5", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$MD5", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f4b1c021e);
            m1ac84fd2(pa80a706fVar, "MD5", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$MD5WithRSAEncryption");
        }
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "SHA1")) {
            pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA1withRSA/PSS", "PSS");
            pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.SHA1WITHRSAANDMGF1", "PSS");
            m900d0bee(pa80a706fVar, "SHA1", strDecryptstring2, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA1withRSA");
            m900d0bee(pa80a706fVar, "SHA1", strDecryptstring6, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA1withRSAandSHAKE128");
            m900d0bee(pa80a706fVar, "SHA1", strDecryptstring7, "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA1withRSAandSHAKE256");
            mc7bd34fd(pa80a706fVar, "SHA1", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA1", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f121cf02c);
            m1ac84fd2(pa80a706fVar, "SHA1", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA1WithRSAEncryption");
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.fc4a65901, "SHA1WITHRSA");
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature.OID." + p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.fc4a65901, "SHA1WITHRSA");
            mb59815af(pa80a706fVar, "SHA1", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$SHA1WithRSAEncryption");
        }
        mc7bd34fd(pa80a706fVar, "SHA224", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA224", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f912eb573);
        mc7bd34fd(pa80a706fVar, strDecryptstring3, "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA256", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5cb5c73);
        mc7bd34fd(pa80a706fVar, "SHA384", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA384", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f5d22c72c);
        mc7bd34fd(pa80a706fVar, strDecryptstring4, "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA512", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f61066e31);
        mc7bd34fd(pa80a706fVar, "SHA512(224)", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA512_224", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb7eb4433);
        mc7bd34fd(pa80a706fVar, "SHA512(256)", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA512_256", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f3997b62c);
        mc7bd34fd(pa80a706fVar, "SHA3-224", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA3_224", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f093af402);
        mc7bd34fd(pa80a706fVar, strDecryptstring5, "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA3_256", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f4fe645e4);
        mc7bd34fd(pa80a706fVar, "SHA3-384", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA3_384", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f65f062e3);
        mc7bd34fd(pa80a706fVar, "SHA3-512", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA3_512", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f3fa23708);
        m1ac84fd2(pa80a706fVar, "SHA224", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA224WithRSAEncryption");
        m1ac84fd2(pa80a706fVar, strDecryptstring3, "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA256WithRSAEncryption");
        m1ac84fd2(pa80a706fVar, "SHA384", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA384WithRSAEncryption");
        m1ac84fd2(pa80a706fVar, strDecryptstring4, "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA512WithRSAEncryption");
        m1ac84fd2(pa80a706fVar, "SHA512(224)", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA512_224WithRSAEncryption");
        m1ac84fd2(pa80a706fVar, "SHA512(256)", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA512_256WithRSAEncryption");
        mb59815af(pa80a706fVar, "SHA224", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$SHA224WithRSAEncryption");
        mb59815af(pa80a706fVar, strDecryptstring3, "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$SHA256WithRSAEncryption");
        mb59815af(pa80a706fVar, "SHA384", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$SHA384WithRSAEncryption");
        mb59815af(pa80a706fVar, strDecryptstring4, "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$SHA512WithRSAEncryption");
        mb59815af(pa80a706fVar, "SHA512(224)", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$SHA512_224WithRSAEncryption");
        mb59815af(pa80a706fVar, "SHA512(256)", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$SHA512_256WithRSAEncryption");
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "RIPEMD128")) {
            mc7bd34fd(pa80a706fVar, "RIPEMD128", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$RIPEMD128", p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f25ad964f);
            mc7bd34fd(pa80a706fVar, "RMD128", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$RIPEMD128", null);
            mb59815af(pa80a706fVar, "RMD128", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$RIPEMD128WithRSAEncryption");
            mb59815af(pa80a706fVar, "RIPEMD128", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$RIPEMD128WithRSAEncryption");
        }
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "RIPEMD160")) {
            mc7bd34fd(pa80a706fVar, "RIPEMD160", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$RIPEMD160", p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f925413d2);
            mc7bd34fd(pa80a706fVar, "RMD160", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$RIPEMD160", null);
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature.RIPEMD160WithRSA/ISO9796-2", "RIPEMD160withRSA/ISO9796-2");
            pa80a706fVar.addAlgorithm("Signature.RIPEMD160withRSA/ISO9796-2", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$RIPEMD160WithRSAEncryption");
            mb59815af(pa80a706fVar, "RMD160", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$RIPEMD160WithRSAEncryption");
            mb59815af(pa80a706fVar, "RIPEMD160", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$RIPEMD160WithRSAEncryption");
        }
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "RIPEMD256")) {
            mc7bd34fd(pa80a706fVar, "RIPEMD256", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$RIPEMD256", p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f3962b304);
            mc7bd34fd(pa80a706fVar, "RMD256", "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$RIPEMD256", null);
        }
        if (pa80a706fVar.hasAlgorithm("MessageDigest", "WHIRLPOOL")) {
            m1ac84fd2(pa80a706fVar, "Whirlpool", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$WhirlpoolWithRSAEncryption");
            m1ac84fd2(pa80a706fVar, "WHIRLPOOL", "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$WhirlpoolWithRSAEncryption");
            mb59815af(pa80a706fVar, "Whirlpool", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$WhirlpoolWithRSAEncryption");
            mb59815af(pa80a706fVar, "WHIRLPOOL", "org.bouncycastle.jcajce.provider.asymmetric.rsa.X931SignatureSpi$WhirlpoolWithRSAEncryption");
        }
    }
}

