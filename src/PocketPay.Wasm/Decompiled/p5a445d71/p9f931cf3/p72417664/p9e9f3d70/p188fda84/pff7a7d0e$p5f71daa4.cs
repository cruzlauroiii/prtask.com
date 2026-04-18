namespace WillowMaze.Wasm.Decompiled;


public class pff7a7d0e$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((12 + 32) % 32 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.DH", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pde667cd0");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.DIFFIEHELLMAN", "DH");
        pa80a706fVar.addAttributes("KeyAgreement.DH", p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pff7a7d0e.mf23e8626());
        pa80a706fVar.addAlgorithm("KeyAgreement.DH", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p51f14de8");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement.DIFFIEHELLMAN", "DH");
        pa80a706fVar.addAlgorithm("KeyAgreement", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe593a803, "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHwithRFC2631KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement", p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fab997565, "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHwithRFC2631KDF");
        pa80a706fVar.addAlgorithm("KeyFactory.DH", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pd4093fa8");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.DIFFIEHELLMAN", "DH");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.DH", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pa68c9a50");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.DIFFIEHELLMAN", "DH");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator.DIFFIEHELLMAN", "DH");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.DH", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p9d46b8e9");
        pa80a706fVar.addAlgorithm("Cipher.IES", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IES");
        pa80a706fVar.addAlgorithm("Cipher.IESwithAES-CBC", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IESwithAESCBC");
        pa80a706fVar.addAlgorithm("Cipher.IESWITHAES-CBC", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IESwithAESCBC");
        pa80a706fVar.addAlgorithm("Cipher.IESWITHDESEDE-CBC", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IESwithDESedeCBC");
        pa80a706fVar.addAlgorithm("Cipher.DHIES", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IES");
        pa80a706fVar.addAlgorithm("Cipher.DHIESwithAES-CBC", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IESwithAESCBC");
        pa80a706fVar.addAlgorithm("Cipher.DHIESWITHAES-CBC", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IESwithAESCBC");
        pa80a706fVar.addAlgorithm("Cipher.DHIESWITHDESEDE-CBC", "org.bouncycastle.jcajce.provider.asymmetric.dh.IESCipher$IESwithDESedeCBC");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHWITHSHA1KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHwithSHA1KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHWITHSHA224KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHwithSHA224KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHWITHSHA256KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHwithSHA256KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHWITHSHA384KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHwithSHA384KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHWITHSHA512KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHwithSHA512KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA1KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA1KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA224KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA224KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA256KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA256KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA384KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA384KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA512KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA512KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA1CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA1CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA224CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA224CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA256CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA256CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA384CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA384CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.DHUWITHSHA512CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$DHUwithSHA512CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA1KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA1KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA224KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA224KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA256KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA256KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA384KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA384KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA512KDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA512KDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA1CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA1CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA224CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA224CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA256CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA256CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA384CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA384CKDF");
        pa80a706fVar.addAlgorithm("KeyAgreement.MQVWITHSHA512CKDF", "org.bouncycastle.jcajce.provider.asymmetric.dh.KeyAgreementSpi$MQVwithSHA512CKDF");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da, "DH", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pd4093fa8());
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0, "DH", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pd4093fa8());
    }
}

