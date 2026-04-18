namespace WillowMaze.Wasm.Decompiled;


public class p66a8f281$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((6 + 1) % 1 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyFactory.LMS", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pa7b92d9b");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc, "LMS");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.LMS", "p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pcb7002bb");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc, "LMS");
        pa80a706fVar.addAlgorithm("Signature.LMS", "org.bouncycastle.pqc.jcajce.provider.lms.LMSSignatureSpi$generic");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc, "LMS");
    }
}

