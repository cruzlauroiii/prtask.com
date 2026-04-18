namespace WillowMaze.Wasm.Decompiled;


public class p48528e6a$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((1 + 20) % 20 > 0) {
        }
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.ELGAMAL", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p9d46b8e9");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.ElGamal", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p9d46b8e9");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.ELGAMAL", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pa68c9a50");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.ElGamal", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pa68c9a50");
        pa80a706fVar.addAlgorithm("Cipher.ELGAMAL", "org.bouncycastle.jcajce.provider.asymmetric.elgamal.CipherSpi$NoPadding");
        pa80a706fVar.addAlgorithm("Cipher.ElGamal", "org.bouncycastle.jcajce.provider.asymmetric.elgamal.CipherSpi$NoPadding");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.ELGAMAL/ECB/PKCS1PADDING", "ELGAMAL/PKCS1");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.ELGAMAL/NONE/PKCS1PADDING", "ELGAMAL/PKCS1");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.ELGAMAL/NONE/NOPADDING", "ELGAMAL");
        pa80a706fVar.addAlgorithm("Cipher.ELGAMAL/PKCS1", "org.bouncycastle.jcajce.provider.asymmetric.elgamal.CipherSpi$PKCS1v1_5Padding");
        pa80a706fVar.addAlgorithm("KeyFactory.ELGAMAL", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd4093fa8");
        pa80a706fVar.addAlgorithm("KeyFactory.ElGamal", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd4093fa8");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.ELGAMAL", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pde667cd0");
        pa80a706fVar.addAlgorithm("KeyValueTupleGenerator.ElGamal", "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pde667cd0");
        registerOid(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17, "ELGAMAL", new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd4093fa8());
        registerOidAlgorithmParameterGenerator(pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17, "ELGAMAL");
    }
}

