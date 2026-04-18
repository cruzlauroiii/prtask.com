namespace WillowMaze.Wasm.Decompiled;


public class pc72e6f6f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pc72e6f6f.class.getName();
    private static readonly java.lang.string f751592a4 = null;
    private static readonly java.lang.string f98ca7137 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((11 + 21) % 21 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.CAST5", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.1.2.840.113533.7.66.10", "CAST5");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.CAST5", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator.1.2.840.113533.7.66.10", "CAST5");
        pa80a706fVar.addAlgorithm("Cipher.CAST5", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f155cd4e9, str + "$CBC");
        pa80a706fVar.addAlgorithm("KeyGenerator.CAST5", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f155cd4e9, "CAST5");
    }
}

