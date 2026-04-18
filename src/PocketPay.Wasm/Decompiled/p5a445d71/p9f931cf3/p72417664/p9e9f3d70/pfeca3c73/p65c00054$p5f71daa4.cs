namespace WillowMaze.Wasm.Decompiled;


public class p65c00054$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f45d24741 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p65c00054.class.getName();
    private static readonly java.lang.string f5f720941 = null;
    private static readonly java.lang.string fb8199339 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((6 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameters.SM4", sb.append(str).append("$AlgParams").tostring());
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.SM4", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("Cipher.SM4", str + "$ECB");
        pa80a706fVar.addAlgorithm("KeyGenerator.SM4", str + "$KeyGen");
        addCMacAlgorithm(pa80a706fVar, "SM4", str + "$CMAC", str + "$KeyGen");
        addGMacAlgorithm(pa80a706fVar, "SM4", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "SM4", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

