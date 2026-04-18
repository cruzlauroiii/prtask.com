namespace WillowMaze.Wasm.Decompiled;

public class P445d0434_p5f71daa4 : P91742cc7
{
    private void M1ac84fd2(pa80a706f P0, string P1, string P2)
    {
        // str: "Signature."
        // str: "WithRSA/ISO9796-2"
        // str: "Alg.Alias.Signature."
        // str: "withRSA/ISO9796-2"
        // str: "WITHRSA/ISO9796-2"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.<init>
        // type: StringBuilder
    }

    private void M900d0bee(pa80a706f P0, string P1, string P2, string P3)
    {
        // str: "Signature."
        // str: "WithRSA/PSS"
        // str: "WithRSAAnd"
        // str: "WithRSASSA-PSS"
        // str: "4ae82166e5256a1207aebc2c924c0c873ea607cc2d654eddb30525799c9f4495"
        // str: "WITHRSAAND"
        // str: "Alg.Alias.Signature."
        // str: "withRSASSA-PSS"
        // str: "withRSAand"
        // str: "WITHRSASSA-PSS"
        // str: "withRSA/PSS"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: string.equals
        // call: StringBuilder.<init>
        // call: pa80a706f.addAlgorithm
        // call: DecryptString.decryptString
        // type: StringBuilder
    }

    private void M900d0bee(pa80a706f P0, string P1, string P2, p364bf33a P3)
    {
        // str: "WithRSASSA-PSS"
        // str: "WithRSA/PSS"
        // str: "withRSA/PSS"
        // str: "Alg.Alias.Signature."
        // str: "withRSASSA-PSS"
        // str: "Signature."
        // str: "WITHRSASSA-PSS"
        // str: "WITHRSAPSS"
        // str: "6f3f65eda4fd97450b813fabc1cbf42958e80b8b7c6bc52be824eea3705476661c1bcbdf68"
        // call: StringBuilder.append
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // type: StringBuilder
    }

    private void Mb59815af(pa80a706f P0, string P1, string P2)
    {
        // str: "WithRSA/X9.31"
        // str: "Alg.Alias.Signature."
        // str: "withRSA/X9.31"
        // str: "WITHRSA/X9.31"
        // str: "Signature."
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pa80a706f.addAlgorithm
        // type: StringBuilder
    }

    private void Mc7bd34fd(pa80a706f P0, string P1, string P2, p364bf33a P3)
    {
        // str: "WithRSAEncryption"
        // str: "Alg.Alias.Signature."
        // str: "/RSA"
        // str: "Alg.Alias.Signature.OID."
        // str: "WITHRSA"
        // str: "Signature."
        // str: "withRSAEncryption"
        // str: "withRSA"
        // str: "WITHRSAENCRYPTION"
        // str: "WithRSA"
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // type: StringBuilder
    }

    public void Configure(pa80a706f P0)
    {
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.ISOSignatureSpi$SHA512_256WithRSAEncryption"
        // str: "MD4"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.CipherSpi$PKCS1v1_5Padding_PublicOnly"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_256withRSAandSHAKE256"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA3_256withRSA"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$MD2"
        // str: "KeyFactory.RSASSA-PSS"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA512withRSA"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA512"
        // str: "576ecea0cdf9662802801de86d06751f34f2b57ff8251729700424ed02e4a14def34bde6"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$RIPEMD160"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$nonePSS"
        // str: "RSASSA-PSS"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA384withRSA"
        // str: "Alg.Alias.AlgorithmParameters.SHA384withRSA/PSS"
        // str: "0fc2c2dbad22e97b1decf81b1543acb02181ecd1f9e6c714a2c3eb62cd1318b1"
        // str: "PSS"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.AlgorithmParametersSpi$OAEP"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.DigestSignatureSpi$SHA3_256"
        // str: "org.bouncycastle.jcajce.provider.asymmetric.rsa.PSSSignatureSpi$SHA224withRSAandSHAKE256"
        // call: pa80a706f.addAlgorithm
        // call: p445d0434$p5f71daa4.registerOidAlgorithmParameters
        // call: p445d0434$p5f71daa4.mb59815af
        // call: p445d0434$p5f71daa4.m900d0bee
        // call: p445d0434$p5f71daa4.m1ac84fd2
        // call: p445d0434$p5f71daa4.mc7bd34fd
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // call: pa80a706f.hasAlgorithm
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p445d0434$p5f71daa4.registerOid
        // call: pa80a706f.addAttributes
        // call: p445d0434.mf23e8626
        // call: pd4093fa8.<init>
        // field: p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f925413d2
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f65f062e3
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f61066e31
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f912eb573
        // field: p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.fc4a65901
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f121cf02c
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f3fa23708
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3.f9b47626c
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f4fe645e4
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1d2f2092
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fbe99c93d
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f093af402
        // field: p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.p10860abd.f4d6d145e
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b
        // type: StringBuilder
        // type: pd4093fa8
    }

}
