namespace WillowMaze.Wasm.Decompiled;


public class pafa62edc$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((13 + 13) % 13 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyFactory.ECGOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pd4093fa8");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.GOST-3410-2001", "ECGOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.ECGOST-3410", "ECGOST3410");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, "ECGOST3410", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pd4093fa8());
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f0697cf12, "ECGOST3410", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pd4093fa8());
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, "ECGOST3410");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.ECGOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pde667cd0");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.ECGOST-3410", "ECGOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.GOST-3410-2001", "ECGOST3410");
        pa80a706fVar.addAlgorithm("Signature.ECGOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.ECGOST-3410", "ECGOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST-3410-2001", "ECGOST3410");
        pa80a706fVar.addAlgorithm("KeyAgreement.ECGOST3410", "org.bouncycastle.jcajce.provider.asymmetric.ecgost.KeyAgreementSpi$ECVKO");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, "ECGOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement.GOST-3410-2001", "ECGOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f2e92fea6, "ECGOST3410");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.ECGOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.ECGOST3410-2012", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.GOST-3410-2001", "ECGOST3410");
        addSignatureAlgorithm(pa80a706fVar, "GOST3411", "ECGOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997", p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f5c4fe67f);
        pa80a706fVar.addAlgorithm("KeyFactory.ECGOST3410-2012", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pd4093fa8");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.GOST-3410-2012", "ECGOST3410-2012");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.ECGOST-3410-2012", "ECGOST3410-2012");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a, "ECGOST3410-2012", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pd4093fa8());
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f9b97977f, "ECGOST3410-2012", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pd4093fa8());
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a, "ECGOST3410-2012");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5, "ECGOST3410-2012", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pd4093fa8());
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f7cba43c4, "ECGOST3410-2012", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pd4093fa8());
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5, "ECGOST3410-2012");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.ECGOST3410-2012", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pde667cd0");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.ECGOST3410-2012", "ECGOST3410-2012");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.GOST-3410-2012", "ECGOST3410-2012");
        pa80a706fVar.addAlgorithm("Signature.ECGOST3410-2012-256", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.ECGOST3410-2012-256", "ECGOST3410-2012-256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST-3410-2012-256", "ECGOST3410-2012-256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST3411WITHECGOST3410-2012-256", "ECGOST3410-2012-256");
        addSignatureAlgorithm(pa80a706fVar, "GOST3411-2012-256", "ECGOST3410-2012-256", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816", p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f6b196174);
        pa80a706fVar.addAlgorithm("Signature.ECGOST3410-2012-512", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.ECGOST3410-2012-512", "ECGOST3410-2012-512");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST-3410-2012-512", "ECGOST3410-2012-512");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST3411WITHECGOST3410-2012-512", "ECGOST3410-2012-512");
        addSignatureAlgorithm(pa80a706fVar, "GOST3411-2012-512", "ECGOST3410-2012-512", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced", p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f6622e730);
        pa80a706fVar.addAlgorithm("KeyAgreement.ECGOST3410-2012-256", "org.bouncycastle.jcajce.provider.asymmetric.ecgost12.KeyAgreementSpi$ECVKO256");
        pa80a706fVar.addAlgorithm("KeyAgreement.ECGOST3410-2012-512", "org.bouncycastle.jcajce.provider.asymmetric.ecgost12.KeyAgreementSpi$ECVKO512");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement." + p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f9b97977f, "ECGOST3410-2012-256");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement." + p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f7cba43c4, "ECGOST3410-2012-512");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement." + p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a, "ECGOST3410-2012-256");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyAgreement." + p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5, "ECGOST3410-2012-512");
    }
}

