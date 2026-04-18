namespace WillowMaze.Wasm.Decompiled;


public class pf9e5ab5a$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((8 + 18) % 18 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyFactory.DSTU4145", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pd4093fa8");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.DSTU-4145-2002", "DSTU4145");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.DSTU4145-3410", "DSTU4145");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a, "DSTU4145", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pd4093fa8());
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a, "DSTU4145");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88f12a25, "DSTU4145", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pd4093fa8());
        registerOidAlgorithmParameters(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88f12a25, "DSTU4145");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.DSTU4145", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pde667cd0");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.DSTU-4145", "DSTU4145");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.DSTU-4145-2002", "DSTU4145");
        pa80a706fVar.addAlgorithm("Signature.DSTU4145", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.DSTU-4145", "DSTU4145");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.DSTU-4145-2002", "DSTU4145");
        addSignatureAlgorithm(pa80a706fVar, "GOST3411", "DSTU4145LE", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p240ad874", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a);
        addSignatureAlgorithm(pa80a706fVar, "GOST3411", "DSTU4145", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997", p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88f12a25);
    }
}

