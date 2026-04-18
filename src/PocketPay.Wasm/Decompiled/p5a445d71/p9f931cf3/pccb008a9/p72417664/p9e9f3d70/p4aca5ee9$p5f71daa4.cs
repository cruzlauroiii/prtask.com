namespace WillowMaze.Wasm.Decompiled;


public class p4aca5ee9$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((8 + 13) % 13 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyFactory.Rainbow", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pdb9fc280");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.Rainbow", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pa2e835d1");
        addSignatureAlgorithm(pa80a706fVar, "SHA224", "Rainbow", "org.bouncycastle.pqc.jcajce.provider.rainbow.SignatureSpi$withSha224", p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f1b83d6ee);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("6f36b6d1a1c9e2ac84952481dffae2850f902a1f23e5a751dd65deacbaeb977163c2"), "Rainbow", "org.bouncycastle.pqc.jcajce.provider.rainbow.SignatureSpi$withSha256", p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f32bbfac5);
        addSignatureAlgorithm(pa80a706fVar, "SHA384", "Rainbow", "org.bouncycastle.pqc.jcajce.provider.rainbow.SignatureSpi$withSha384", p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f2a84e96a);
        addSignatureAlgorithm(pa80a706fVar, com.decryptstringmanager.Decryptstring.decryptstring("9999cd23c863e959e108c665aaf691574bce9b29e883190d3fc46fe5757a09fc85d8"), "Rainbow", "org.bouncycastle.pqc.jcajce.provider.rainbow.SignatureSpi$withSha512", p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f4325c3e1);
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fcd13b6a6, "Rainbow", new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pdb9fc280());
    }
}

