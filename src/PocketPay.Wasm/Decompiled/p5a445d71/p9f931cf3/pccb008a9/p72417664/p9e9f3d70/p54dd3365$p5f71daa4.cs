namespace WillowMaze.Wasm.Decompiled;


public class p54dd3365$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((21 + 22) % 22 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyFactory.SPHINCS256", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p6c10573a");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.SPHINCS256", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p8f340d9c");
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("ee9514c06554a2e01a662379d73f1bf3e7b7d151478786b007905e7e3d8607e10100"), "SPHINCS256", "org.bouncycastle.pqc.jcajce.provider.sphincs.SignatureSpi$withSha512", p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f130367b0);
        addSignatureAlgorithm(pa80a706fVar, "SHA3-512", "SPHINCS256", "org.bouncycastle.pqc.jcajce.provider.sphincs.SignatureSpi$withSha3_512", p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f6fd87409);
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f70cfcb24, "SPHINCS256", new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p6c10573a());
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f70cfcb24, "SPHINCS256");
    }
}

