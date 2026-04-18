namespace WillowMaze.Wasm.Decompiled;


public class pdf30d7ec$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f16699a81 = null;
    private static readonly java.lang.string f4b10a1e5 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pdf30d7ec.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((22 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Mac.BLOWFISHCMAC", sb.append(str).append("$CMAC").tostring());
        pa80a706fVar.addAlgorithm("Cipher.BLOWFISH", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.ff7ca3334, str + "$CBC");
        pa80a706fVar.addAlgorithm("KeyGenerator.BLOWFISH", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.ff7ca3334, "BLOWFISH");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.BLOWFISH", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.ff7ca3334, "BLOWFISH");
    }
}

