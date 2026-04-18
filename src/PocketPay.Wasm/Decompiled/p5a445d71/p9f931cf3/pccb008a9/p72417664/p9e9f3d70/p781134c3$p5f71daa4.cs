namespace WillowMaze.Wasm.Decompiled;


public class p781134c3$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((4 + 4) % 4 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyFactory.XMSS", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa0b28dcc");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.XMSS", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa235b83e");
        pa80a706fVar.addAlgorithm("Signature.XMSS", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$generic");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.fec388c63, "XMSS");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.OID." + p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.fec388c63, "XMSS");
        addSignatureAlgorithm(pa80a706fVar, "XMSS-SHA256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withSha256", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f9b3ea17c);
        addSignatureAlgorithm(pa80a706fVar, "XMSS-SHAKE128", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withShake128", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.faa803583);
        addSignatureAlgorithm(pa80a706fVar, "XMSS-SHA512", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withSha512", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.fd39f8541);
        addSignatureAlgorithm(pa80a706fVar, "XMSS-SHAKE256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withShake256", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f09fd7d3d);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("d79b43102e85dad6020cf96c5b531f8d5d6a4301967c6a91a9c4ec32494504ae30cb"), "XMSS-SHA256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withSha256andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f4abb3e40);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("0e90d1c8de8f5eb0cf29eb3438ebe9b8a0b3f41c933689a5ac5ce710e86d590942238069"), "XMSS-SHAKE128", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withShake128andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.ff85211f8);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("bb3e6f1ed5647ed57f976d61bb94905bf50a462203bc09c3857ad3865cc4ca114742"), "XMSS-SHA512", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withSha512andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f302ede48);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("ec483382d0276c2cb8c061e002b2db2bb756ec53356f1762c951aeaa580c267677757527"), "XMSS-SHAKE256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSSignatureSpi$withShake256andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.fddbbb68c);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA256WITHXMSS", "SHA256WITHXMSS-SHA256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHAKE128WITHXMSS", "SHAKE128WITHXMSS-SHAKE128");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA512WITHXMSS", "SHA512WITHXMSS-SHA512");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHAKE256WITHXMSS", "SHAKE256WITHXMSS-SHAKE256");
        pa80a706fVar.addAlgorithm("KeyFactory.XMSSMT", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p786b122d");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.XMSSMT", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p60c7d1f8");
        pa80a706fVar.addAlgorithm("Signature.XMSSMT", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$generic");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.f18ac65f4, "XMSSMT");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.OID." + p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.f18ac65f4, "XMSSMT");
        addSignatureAlgorithm(pa80a706fVar, "XMSSMT-SHA256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withSha256", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f5441920b);
        addSignatureAlgorithm(pa80a706fVar, "XMSSMT-SHAKE128", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withShake128", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.ff9b1a4c6);
        addSignatureAlgorithm(pa80a706fVar, "XMSSMT-SHA512", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withSha512", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.fea8ee104);
        addSignatureAlgorithm(pa80a706fVar, "XMSSMT-SHAKE256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withShake256", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f51e59498);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("0403692ad55aa712569b91751639dfbd7c1f9dc68a0dfac7bd289e2becad7569bfc3"), "XMSSMT-SHA256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withSha256andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.fd31c35d9);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("480c3c83ee6f213228f96b9293e8f2c851433c01f3d709ed2cb6ec24b3445dfa0463047f"), "XMSSMT-SHAKE128", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withShake128andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f72af53fe);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("b2d26bfb9d852c54008da46a8454b4991feaed3ee6b54705be5e543894d046a913db"), "XMSSMT-SHA512", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withSha512andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f6914c0b2);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("6012380861f2a7d24f43851a16995d87312d1f83ec8ba0da979452092963ebf2c671da19"), "XMSSMT-SHAKE256", "org.bouncycastle.pqc.jcajce.provider.xmss.XMSSMTSignatureSpi$withShake256andPrehash", p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.ff97c9592);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA256WITHXMSSMT", "SHA256WITHXMSSMT-SHA256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHAKE128WITHXMSSMT", "SHAKE128WITHXMSSMT-SHAKE128");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHA512WITHXMSSMT", "SHA512WITHXMSSMT-SHA512");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.SHAKE256WITHXMSSMT", "SHAKE256WITHXMSSMT-SHAKE256");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f4aeb1bcf, "XMSS", new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa0b28dcc());
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.fec388c63, "XMSS", new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa0b28dcc());
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f2ae6fdb4, "XMSSMT", new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p786b122d());
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.f18ac65f4, "XMSSMT", new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p786b122d());
    }
}

