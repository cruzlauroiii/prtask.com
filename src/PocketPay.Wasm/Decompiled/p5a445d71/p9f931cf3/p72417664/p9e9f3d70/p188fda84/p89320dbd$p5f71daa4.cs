namespace WillowMaze.Wasm.Decompiled;


public class p89320dbd$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((5 + 20) % 20 > 0) {
        }
        pa80a706fVar.addAlgorithm("AlgorithmParameters.DSA", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pa68c9a50");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.DSA", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p9d46b8e9");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.DSA", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pde667cd0");
        pa80a706fVar.addAlgorithm("KeyFactory.DSA", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pd4093fa8");
        pa80a706fVar.addAlgorithm("Signature.DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$stdDSA");
        pa80a706fVar.addAlgorithm("Signature.NONEWITHDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$noneDSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.RAWDSA", "NONEWITHDSA");
        pa80a706fVar.addAlgorithm("Signature.DETDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA");
        pa80a706fVar.addAlgorithm("Signature.SHA1WITHDETDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA");
        pa80a706fVar.addAlgorithm("Signature.SHA224WITHDETDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA224");
        pa80a706fVar.addAlgorithm("Signature.SHA256WITHDETDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA256");
        pa80a706fVar.addAlgorithm("Signature.SHA384WITHDETDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA384");
        pa80a706fVar.addAlgorithm("Signature.SHA512WITHDETDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA512");
        pa80a706fVar.addAlgorithm("Signature.DDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA");
        pa80a706fVar.addAlgorithm("Signature.SHA1WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA");
        pa80a706fVar.addAlgorithm("Signature.SHA224WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA224");
        pa80a706fVar.addAlgorithm("Signature.SHA256WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA256");
        pa80a706fVar.addAlgorithm("Signature.SHA384WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA384");
        pa80a706fVar.addAlgorithm("Signature.SHA512WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSA512");
        pa80a706fVar.addAlgorithm("Signature.SHA3-224WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSASha3_224");
        pa80a706fVar.addAlgorithm("Signature.SHA3-256WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSASha3_256");
        pa80a706fVar.addAlgorithm("Signature.SHA3-384WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSASha3_384");
        pa80a706fVar.addAlgorithm("Signature.SHA3-512WITHDDSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$detDSASha3_512");
        addSignatureAlgorithm(pa80a706fVar, "SHA224", "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsa224", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f8881b303);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("1d0738236f1cbafa04290fc23120928132c41828f07fc430ad8270f8763712396188"), "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsa256", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fedb86669);
        addSignatureAlgorithm(pa80a706fVar, "SHA384", "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsa384", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f964bf4ab);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("c8bf7949e12439412c0c841e64c39221fb8ff080a64d0c3e9f567526dd74f61b30c6"), "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsa512", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f63ce9d48);
        addSignatureAlgorithm(pa80a706fVar, "SHA3-224", "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsaSha3_224", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fc62b4722);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("4dd71f0bdfd3e1ba02e433c060c715b51f32fb915b3f325b62413c75c0d666c299ca17c8"), "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsaSha3_256", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f44d22969);
        addSignatureAlgorithm(pa80a706fVar, "SHA3-384", "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsaSha3_384", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fb091af5f);
        addSignatureAlgorithm(pa80a706fVar, "SHA3-512", "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsaSha3_512", p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f3f0985a5);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA/DSA", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA1withDSA", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA1WITHDSA", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.1.3.14.3.2.26with1.2.840.10040.4.1", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.1.3.14.3.2.26with1.2.840.10040.4.3", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.DSAwithSHA1", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.DSAWITHSHA1", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA1WithDSA", "DSA");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.DSAWithSHA1", "DSA");
        addSignatureAlgorithm(pa80a706fVar, "RIPEMD160", "DSA", "org.bouncycastle.jcajce.provider.asymmetric.dsa.DSASigner$dsaRMD160");
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pd4093fa8 pd4093fa8Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pd4093fa8();
        for (int i = 0; i != p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.f9992f3eb.length; i++) {
            pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.f9992f3eb[i], "DSA");
            registerOid(pa80a706fVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.f9992f3eb[i], "DSA", pd4093fa8Var);
            registerOidAlgorithmParameterGenerator(pa80a706fVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.f9992f3eb[i], "DSA");
        }
    }
}

