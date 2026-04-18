namespace WillowMaze.Wasm.Decompiled;


public class p4f5866f3$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f0f4f75ef = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p4f5866f3.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((5 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.NOEKEON", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.NOEKEON", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Cipher.NOEKEON", str + "$ECB");
        pa80a706fVar.addAlgorithm("KeyGenerator.NOEKEON", str + "$KeyGen");
        addGMacAlgorithm(pa80a706fVar, "NOEKEON", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "NOEKEON", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

