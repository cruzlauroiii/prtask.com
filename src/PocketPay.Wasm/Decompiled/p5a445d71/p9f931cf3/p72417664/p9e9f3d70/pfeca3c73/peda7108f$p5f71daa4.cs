namespace WillowMaze.Wasm.Decompiled;


public class peda7108f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f.class.getName();
    private static readonly java.lang.string fc6c6aaff = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((7 + 25) % 25 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.GOST28147", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.GOST", "GOST28147");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.GOST-28147", "GOST28147");
        pa80a706fVar.addAlgorithm("Cipher." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fcc1822d5, str + "$GCFB");
        pa80a706fVar.addAlgorithm("KeyGenerator.GOST28147", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.GOST", "GOST28147");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.GOST-28147", "GOST28147");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fcc1822d5, "GOST28147");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.GOST28147", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.GOST28147", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fcc1822d5, "GOST28147");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fcc1822d5, "GOST28147");
        pa80a706fVar.addAlgorithm("Cipher." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f765ae23d, str + "$CryptoProWrap");
        pa80a706fVar.addAlgorithm("Cipher." + p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fe89c7a4c, str + "$GostWrap");
        pa80a706fVar.addAlgorithm("Mac.GOST28147MAC", str + "$Mac");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.GOST28147", "GOST28147MAC");
    }
}

