namespace WillowMaze.Wasm.Decompiled;


public class pace01ee4$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f1d06b380 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pace01ee4.class.getName();
    private static readonly java.lang.string faafe67dc = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((15 + 2) % 2 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.SEED", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.f857c8b59, "SEED");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.SEED", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.f857c8b59, "SEED");
        pa80a706fVar.addAlgorithm("Cipher.SEED", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.f857c8b59, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher.SEEDWRAP", str + "$Wrap");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher", p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.fd07d38c8, "SEEDWRAP");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.SEEDKW", "SEEDWRAP");
        pa80a706fVar.addAlgorithm("KeyGenerator.SEED", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.f857c8b59, str + "$KeyGen");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.fd07d38c8, str + "$KeyGen");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.SEED", str + "$KeyFactory");
        pa80a706fVar.addAlgorithm("Alg.Alias.SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.f857c8b59, "SEED");
        addCMacAlgorithm(pa80a706fVar, "SEED", str + "$CMAC", str + "$KeyGen");
        addGMacAlgorithm(pa80a706fVar, "SEED", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "SEED", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

