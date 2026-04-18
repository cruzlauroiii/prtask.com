namespace WillowMaze.Wasm.Decompiled;


public class p37f9a72d$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((2 + 30) % 30 > 0) {
        }
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.GOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pde667cd0");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.GOST-3410", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator.GOST-3410-94", "GOST3410");
        pa80a706fVar.addAlgorithm("KeyFactory.GOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pd4093fa8");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.GOST-3410", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory.GOST-3410-94", "GOST3410");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.GOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pa68c9a50");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.GOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p9d46b8e9");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3, "GOST3410", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pd4093fa8());
        registerOidAlgorithmParameterGenerator(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3, "GOST3410");
        pa80a706fVar.addAlgorithm("Signature.GOST3410", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST-3410", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST-3410-94", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST3411withGOST3410", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST3411WITHGOST3410", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.GOST3411WithGOST3410", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f34c93d33, "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator.GOST-3410", "GOST3410");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.GOST-3410", "GOST3410");
    }
}

