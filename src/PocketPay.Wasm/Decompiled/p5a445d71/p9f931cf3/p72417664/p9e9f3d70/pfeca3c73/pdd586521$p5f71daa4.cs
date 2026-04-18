namespace WillowMaze.Wasm.Decompiled;


public class pdd586521$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f32fa7f5d = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pdd586521.class.getName();
    private static readonly java.lang.string f665647a9 = null;
    private static readonly java.lang.string f9513b265 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((24 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.CAST6", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.CAST6", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.CAST6", str + "$AlgParams");
        addGMacAlgorithm(pa80a706fVar, "CAST6", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "CAST6", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

